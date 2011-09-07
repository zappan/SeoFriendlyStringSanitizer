using System;
using System.Text;

namespace Netko.Common.Util.Seo
{
	public static class SeoFriendlyStringSanitizer
	{
		/// <summary>Sanitizes given input string to a SEO friendly output string</summary>
		/// <param name="input">Input string</param>
		/// <returns>Sanitized output</returns>
		public static string Sanitize(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return input;
			}

			string normalizedString = DiacriticalFoldingService.FoldDiacriticals(input);

			StringBuilder sb = new StringBuilder();
			bool lastCharWasWhitespace = false;
			bool strippingHtmlMode = false;
			for (int index = 0; index < normalizedString.Length; index++)
			{
				char curChar = normalizedString[index];

				// check if string contains HTML elements, they should be stripped
				if (curChar == '<')
				{
					strippingHtmlMode = true;
					continue;
				}
				else if (curChar == '>')
				{
					strippingHtmlMode = false;
					continue;
				}

				// if inside HTML element, we're in stripping mode and skipping the current character
				if (strippingHtmlMode)
					continue;

				// not inside stripping mode, perform transformations
				if (Char.IsWhiteSpace(curChar) || curChar == '-')
				{
					if (!lastCharWasWhitespace)
					{
						sb.Append('-');
					}
					lastCharWasWhitespace = true;
					continue;
				}

				if (Char.IsPunctuation(curChar)) continue;
				if (curChar == '\u00F8') continue;

				sb.Append(curChar);
				lastCharWasWhitespace = false;
			}

			return sb.ToString().ToLowerInvariant();
		}
	}
}
