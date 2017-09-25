# String Interpolation

> `$"<text> {<interpolated-expression> [,<field-width>] [:<format-string>] } <text> ..."`
> where:
> - field-width is a signed integer that indicates the number of characters in the field. If it is positive, the field is right-aligned; if negative, left-aligned.
> - format-string is a format string appropriate for the type of object being formatted. For example, for a DateTime value, it could be a standard date and time format string such as "D" or "d".
> <cite>[Interpolated Strings (C# Reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interpolated-strings)</cite>

The `<format-string>` can be either

- [Standard numeric](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings) or [custom numeric](https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings)
- [Standard date/time](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings) or [custom date/time](https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings)

