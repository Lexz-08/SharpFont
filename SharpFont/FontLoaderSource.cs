using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace SharpFont
{
	public class FontLoader
	{
		// get the list of installed font families on the computer
		public static FontFamily[] InstalledFamilies => new InstalledFontCollection().Families;
		public static List<FontFamily> InstalledFamilies_List => new InstalledFontCollection().Families.ToList();

		// convert the list of font families to a list of fonts
		public static Font[] InstalledFonts
		{
			get
			{
				Font[] installedFonts = new Font[InstalledFamilies.Length];
				for (int i = 0; i < installedFonts.Length; i++)
				{
					installedFonts[i] = new Font(InstalledFamilies[i].Name, 0.0f, FontStyle.Regular);
				}
				return installedFonts;
			}
		}
		public static List<Font> InstalledFonts_List => InstalledFonts.ToList();

		// create an empty list of strings and replace the strings with the names of the installed fonts
		public static string[] InstalledFontNames
		{
			get
			{
				string[] installedFontNames = new string[InstalledFonts.Length];
				for (int i = 0; i < installedFontNames.Length; i++)
				{
					installedFontNames[i] = InstalledFonts[i].Name;
				}
				return installedFontNames;
			}
		}
		public static List<string> InstalledFontNames_List => InstalledFontNames.ToList();

		// load a font family from a byte array
		public static FontFamily LoadFamily(byte[] data)
		{
			GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				IntPtr ptr = Marshal.UnsafeAddrOfPinnedArrayElement(data, 0);
				using (PrivateFontCollection pvc = new PrivateFontCollection())
				{
					pvc.AddMemoryFont(ptr, data.Length);
					return pvc.Families[0];
				}
			}
			finally
			{
				handle.Free();
			}
		}
		
		// load a font from a byte array
		public static Font LoadFont(byte[] data, float desiredSize)
		{
			FontFamily fontFamily = LoadFamily(data);
			return new Font(fontFamily.Name, desiredSize);
		}
		public static Font LoadFont(byte[] data, float desiredSize, FontStyle desiredStyle)
		{
			FontFamily fontFamily = LoadFamily(data);
			return new Font(fontFamily.Name, desiredSize, desiredStyle);
		}

		// load a font family from a file
		public static FontFamily LoadFamily(string fileName)
		{
			byte[] data = File.ReadAllBytes(fileName);
			return LoadFamily(data);
		}
		
		// load a font from a file
		public static Font LoadFont(string fileName, float desiredSize)
		{
			FontFamily fontFamily = LoadFamily(fileName);
			return new Font(fontFamily.Name, desiredSize);
		}
		public static Font LoadFont(string fileName, float desiredSize, FontStyle desiredStyle)
		{
			FontFamily fontFamily = LoadFamily(fileName);
			return new Font(fontFamily.Name, desiredSize, desiredStyle);
		}
	}
}
