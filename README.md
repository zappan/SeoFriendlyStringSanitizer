SEO Friendly String Sanitizer
========================================

This is a small .Net library that performs the string conversion into a sanitized version that can be included in the URL.
It performs diacritical folding, removing of punctuation and replacing whitespace with URL friendly dashes.

This work is based on the diacritical folding 
[work of Peter Ritchie (MVP)](http://social.msdn.microsoft.com/Forums/en-US/netfxbcl/thread/a33217d3-86e6-4759-a12c-c407969e479f/#50b5126a-2b71-4089-9769-1f1c796d5b0e)
published on MSDN blog, which is further based on [Draft UTR #30: Unicode Character Foldings](http://www.unicode.org/reports/tr30/)
and the associated [datafile](http://www.unicode.org/reports/tr30/datafiles/DiacriticFolding.txt).

The library and provided on an "as is" basis.

## Installation

The library is available as a [NuGet package](http://nuget.org/List/Packages/Netko.Common.Util.Seo.SeoFriendlyStringSanitizer) or by cloning the GitHub repository and building it directly.

## Usage

```c#
using Netko.Common.Util.Seo;
...
string output = SeoFriendlyStringSanitizer.Sanitize(input);
```

## History

* [2011-09-07] v1.0.1: Stripping HTML elements from the input string
* [2011-09-03] v1.0.0: Initial release

## Resources
* Getting the library: [NuGet package](http://nuget.org/List/Packages/Netko.Common.Util.Seo.SeoFriendlyStringSanitizer)
* The Unicode Consortium: [http://www.unicode.org/](http://www.unicode.org/)
* Origin MSDN Blog Post: [Stripping diacriticals from string?](http://social.msdn.microsoft.com/Forums/en-US/netfxbcl/thread/a33217d3-86e6-4759-a12c-c407969e479f/)
