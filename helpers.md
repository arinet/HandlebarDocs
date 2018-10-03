# Custom Helpers
> These helpers all return values inline; when you reference one, its reference gets replaced by the resulting value.
>
>For example: `<strong>{{Helper.String.Uppercase "some string"}}</strong>` would return `<strong>SOME STRING</strong>`

---
* HTML
    * [Helpers.Html.Escape](#helpershtmlescape)
    * [Helpers.Html.HtmlDecode](#helpershtmlhtmldecode)
    * [Helpers.Html.HtmlEncode](#helpershtmlhtmlencode)
* Math
    * [Helpers.Math.Add](#helpersmathadd)
    * [Helpers.Math.Ceiling](#helpersmathceiling)
    * [Helpers.Math.Divide](#helpersmathdivide)
    * [Helpers.Math.Floor](#helpersmathfloor)
    * [Helpers.Math.Mod](#helpersmathmod)
    * [Helpers.Math.Multiply](#helpersmathmultiply)
    * [Helpers.Math.Round](#helpersmathround)
    * [Helpers.Math.Subtract](#helpersmathsubtract)
* Number
    * [Helpers.Number.FormatPrice](#helpersnumberformatprice)
* Object
    * [Helpers.Object.GetLength](#helpersobjectgetlength)
* Path
    * [Helpers.Path.GetAbsolutePath](#helperspathgetabsolutepath)
    * [Helpers.Path.GetDirectory](#helperspathgetdirectory)
    * [Helpers.Path.GetExtension](#helperspathgetextension)
    * [Helpers.Path.GetFilename](#helperspathgetfilename)
* String
    * [Helpers.String.Append](#helpersstringappend)
    * [Helpers.String.Ellipsis](#helpersstringellipsis)
    * [Helpers.String.Lowercase](#helpersstringlowercase)
    * [Helpers.String.Occurrences](#helpersstringoccurrences)
    * [Helpers.String.Prepend](#helpersstringprepend)
    * [Helpers.String.Replace](#helpersstringreplace)
    * [Helpers.String.Reverse](#helpersstringreverse)
    * [Helpers.String.Titlecase](#helpersstringtitlecase)
    * [Helpers.String.Trim](#helpersstringtrim)
    * [Helpers.String.TrimLeft](#helpersstringtrimleft)
    * [Helpers.String.TrimRight](#helpersstringtrimright)
    * [Helpers.String.Truncate](#helpersstringtruncate)
    * [Helpers.String.TruncateWords](#helpersstringtruncatewords)
    * [Helpers.String.Uppercase](#helpersstringuppercase)
* Url
    * [Helpers.Url.Base64Decode](#helpersurlbase64decode)
    * [Helpers.Url.Base64Encode](#helpersurlbase64encode)
    * [Helpers.Url.DecodeUri](#helpersurldecodeuri)
    * [Helpers.Url.EncodeUri](#helpersurlencodeuri)
    * [Helpers.Url.StripProtocol](#helpersurlstripprotocol)

---
## Helpers.Html.Escape
|||
|-|-|
|**Summary**|An escape function similar to what exists in javascript. This will compute a new string which certain characters have been replaced by a hexadecimal escape sequence|
|**Returns**|The newly escaped string|
|**Remarks**|/ characters will be escaped with a \|
|||
|**Parameters**||
|_str_|String to escape|

### Example
**Context**
``` json
{
    "value": "https://github.com/arinet/HandlebarDocs/blob/master/helpers.md#helpershtmlescape"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Html.Escape value}}
```
**Returns**
``` html
<strong>result:</strong>
https:\/\/github.com\/arinet\/HandlebarDocs\/blob\/master\/docs\/helpers.md#helpershtmlescape
```

---
## Helpers.Html.HtmlDecode
|||
|-|-|
|**Summary**|Converts a string that has been HTML-encoded for HTTP transmission|
|**Returns**|Decoded string|
|**Remarks**|If characters such as blanks and punctuation are passed in an HTTP stream, they might be misinterpreted at the receiving end. HTML encoding converts characters that are not allowed in HTML into character-entity equivalents; HTML decoding reverses the encoding. For example, when embedded in a block of text, the characters < and > are encoded as &lt; and &gt; for HTTP transmission.|
|||
|**Parameters**||
|_html_|String to decode|

### Example
**Context**
``` json
{
    "value": "Enter a string having &#39;&amp;&#39; or &#39;&quot;&#39;  in it:"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Html.HtmlDecode value}}
```
**Returns**
``` html
<strong>result:</strong>
Enter a string having '&' or '"'  in it:
```

---
## Helpers.Html.HtmlEncode
|||
|-|-|
|**Summary**|Converts a string to an HTML-encoded string|
|**Returns**|Encoded string|
|**Remarks**|If characters such as blanks and punctuation are passed in an HTTP stream, they might be misinterpreted at the receiving end. HTML encoding converts characters that are not allowed in HTML into character-entity equivalents; HTML decoding reverses the encoding. For example, when embedded in a block of text, the characters < and > are encoded as &lt; and &gt; for HTTP transmission.|
|||
|**Parameters**||
|_html_|String to encode|

### Example
**Context**
``` json
{
    "value": "Enter a string having '&' or '\"'  in it:"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Html.HtmlEncode value}}
```
**Returns**
``` html
<strong>result:</strong>
Enter a string having &#39;&amp;&#39; or &#39;&quot;&#39;  in it:
```

---
## Helpers.Math.Add
|||
|-|-|
|**Summary**|Add two numbers|
|**Returns**|Sum of inputs|
|**Remarks**||
|||
|**Parameters**||
|_input1_|First input|
|_input2_|Second input|

### Example
**Context**
``` json
{
    "a": 1,
    "b": 2,
    "c": 3
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Add a b}}
{{Helpers.Math.Add b c}}
{{Helpers.Math.Add c 4}}
{{Helpers.Math.Add 4 5}}
```
**Returns**
``` html
<strong>result:</strong>
3
5
7
9
```

---
## Helpers.Math.Ceiling
|||
|-|-|
|**Summary**|Rounds input up to the nearest whole number|
|**Returns**|Ceiling of input|
|**Remarks**||
|||
|**Parameters**||
|_input_|input|

### Example
**Context**
``` json
{
    "a": 1.23,
    "b": 2.45,
    "c": 3.67
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Ceiling a}}
{{Helpers.Math.Ceiling b}}
{{Helpers.Math.Ceiling c}}
{{Helpers.Math.Ceiling 4.89}}
```
**Returns**
``` html
<strong>result:</strong>
2
3
4
5
```

---
## Helpers.Math.Divide
|||
|-|-|
|**Summary**|Divide first input by second input|
|**Returns**|Result of first input divided by second input|
|**Remarks**||
|||
|**Parameters**||
|_input1_|First input|
|_input2_|Second input|

### Example
**Context**
``` json
{
    "a": 1,
    "b": 2,
    "c": 3
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Divide a b}}
{{Helpers.Math.Divide b c}}
{{Helpers.Math.Divide c 4}}
{{Helpers.Math.Divide 4 5}}
```
**Returns**
``` html
<strong>result:</strong>
0.5
0.666666666666667
0.75
0.8
```

---
## Helpers.Math.Floor
|||
|-|-|
|**Summary**|Rounds input down to the nearest whole number|
|**Returns**|Floor of input|
|**Remarks**||
|||
|**Parameters**||
|_input_|input|

### Example
**Context**
``` json
{
    "a": 1.23,
    "b": 2.45,
    "c": 3.67
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Floor a}}
{{Helpers.Math.Floor b}}
{{Helpers.Math.Floor c}}
{{Helpers.Math.Floor 4.89}}
```
**Returns**
``` html
<strong>result:</strong>
1
2
3
4
```

---
## Helpers.Math.Mod
|||
|-|-|
|**Summary**|Modulus of first over second input|
|**Returns**|Result of modulus of first input over second input|
|**Remarks**||
|||
|**Parameters**||
|_input1_|First input|
|_input2_|Second input|

### Example
**Context**
``` json
{
    "a": 1,
    "b": 2,
    "c": 3
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Mod a b}}
{{Helpers.Math.Mod b c}}
{{Helpers.Math.Mod c 4}}
{{Helpers.Math.Mod 4 5}}
```
**Returns**
``` html
<strong>result:</strong>
1
2
3
4
```

---
## Helpers.Math.Multiply
|||
|-|-|
|**Summary**|Multiply first input by second input|
|**Returns**|Result of multiplication of first input and second input|
|**Remarks**||
|||
|**Parameters**||
|_input1_|First input|
|_input2_|Second input|

### Example
**Context**
``` json
{
    "a": 1,
    "b": 2,
    "c": 3
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Multiply a b}}
{{Helpers.Math.Multiply b c}}
{{Helpers.Math.Multiply c 4}}
{{Helpers.Math.Multiply 4 5}}
```
**Returns**
``` html
<strong>result:</strong>
2
6
12
20
```

---
## Helpers.Math.Round
|||
|-|-|
|**Summary**|Rounds input to the nearest whole number|
|**Returns**|Rounded input|
|**Remarks**|Rounds depending on what side of the half the number falls on|
|||
|**Parameters**||
|_input_|input|

### Example
**Context**
``` json
{
    "a": 1.23,
    "b": 2.45,
    "c": 3.67
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Round a}}
{{Helpers.Math.Round b}}
{{Helpers.Math.Round c}}
{{Helpers.Math.Round 4.89}}
```
**Returns**
``` html
<strong>result:</strong>
1
2
4
5
```

---
## Helpers.Math.Subtract
|||
|-|-|
|**Summary**|Subtract second input from first|
|**Returns**|Result of subtracting the second input from first|
|**Remarks**||
|||
|**Parameters**||
|_input1_|First input|
|_input2_|Second input|

### Example
**Context**
``` json
{
    "a": 4,
    "b": 3,
    "c": 1
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Subtract a b}}
{{Helpers.Math.Subtract b c}}
{{Helpers.Math.Subtract c 2}}
{{Helpers.Math.Subtract 2 5}}
```
**Returns**
``` html
<strong>result:</strong>
1
2
-1
-3
```

---
## Helpers.Number.FormatPrice
|||
|-|-|
|**Summary**|Format number as price|
|**Returns**|Formatted price|
|**Remarks**||
|||
|**Parameters**||
|_number_|Number to format|

### Example
**Context**
``` json
{
    "a": 1,
    "b": 10.59,
    "c": 1000.123
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Number.FormatPrice a}}
{{Helpers.Number.FormatPrice b}}
{{Helpers.Number.FormatPrice c}}
{{Helpers.Number.FormatPrice 0.25}}
```
**Returns**
``` html
<strong>result:</strong>
1.00
10.59
1,000.12
0.25
```

---
## Helpers.Object.GetLength
|||
|-|-|
|**Summary**|Gets the length of an array|
|**Returns**|Number of elements in the inputted array|
|**Remarks**|If input is not an array, this will return 0|
|||
|**Parameters**||
|_input_|Array to get length of|

### Example
**Context**
``` json
{
    "a": [],
    "b": [
        "one",
        "two"
    ],
    "c": [
        1
    ],
    "d": [
        {
            "id": 1
        },
        {
            "id": 2
        }
    ]
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Object.GetLength a}}
{{Helpers.Object.GetLength b}}
{{Helpers.Object.GetLength c}}
{{Helpers.Object.GetLength d}}
```
**Returns**
``` html
<strong>result:</strong>
0
2
1
2
```

---
## Helpers.Path.GetAbsolutePath
|||
|-|-|
|**Summary**|Given path, get just the folder paths|
|**Returns**|Folder paths|
|**Remarks**||
|||
|**Parameters**||
|_path_|Path to pull info from|
|_delimiter_|Delimiter to parse path with, defaults to /|

### Example
**Context**
``` json
{
    "a": "/first/second/third/somefile.txt",
    "b": "first_second_third_somefile.txt"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Path.GetAbsolutePath a}}
{{Helpers.Path.GetAbsolutePath b "_"}}
{{Helpers.Path.GetAbsolutePath "arinet/HandlebarDocs/blob/master/helpers.md"}}
```
**Returns**
``` html
<strong>result:</strong>
/first/second/third
_first_second_third
/arinet/HandlebarDocs/blob/master/docs
```

---
## Helpers.Path.GetDirectory
|||
|-|-|
|**Summary**|Given path, get top level directory name|
|**Returns**|Top level directory name|
|**Remarks**||
|||
|**Parameters**||
|_path_|Path to pull info from|
|_delimiter_|Delimiter to parse path with, defaults to /|

### Example
**Context**
``` json
{
    "a": "/first/second/third/somefile.txt",
    "b": "first_second_third_somefile.txt"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Path.GetDirectory a}}
{{Helpers.Path.GetDirectory b "_"}}
{{Helpers.Path.GetDirectory "arinet/HandlebarDocs/blob/master/helpers.md"}}
```
**Returns**
``` html
<strong>result:</strong>
third
third
docs
```

---
## Helpers.Path.GetExtension
|||
|-|-|
|**Summary**|Given path, get file extension|
|**Returns**|File extension|
|**Remarks**||
|||
|**Parameters**||
|_path_|Path to pull info from|
|_delimiter_|Delimiter to parse path with, defaults to /|

### Example
**Context**
``` json
{
    "a": "/first/second/third/somefile.txt",
    "b": "first_second_third_somefile.txt"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Path.GetExtension a}}
{{Helpers.Path.GetExtension b "_"}}
{{Helpers.Path.GetExtension "arinet/HandlebarDocs/blob/master/helpers.md"}}
```
**Returns**
``` html
<strong>result:</strong>
txt
txt
md
```

---
## Helpers.Path.GetFilename
|||
|-|-|
|**Summary**|Given path, get file name|
|**Returns**|File name|
|**Remarks**||
|||
|**Parameters**||
|_path_|Path to pull info from|
|_delimiter_|Delimiter to parse path with, defaults to /|

### Example
**Context**
``` json
{
    "a": "/first/second/third/somefile.txt",
    "b": "first_second_third_somefile.txt"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Path.GetFilename a}}
{{Helpers.Path.GetFilename b "_"}}
{{Helpers.Path.GetFilename "arinet/HandlebarDocs/blob/master/helpers.md"}}
```
**Returns**
``` html
<strong>result:</strong>
somefile.txt
somefile.txt
helpers.md
```

---
## Helpers.String.Append
|||
|-|-|
|**Summary**|Append one string to another|
|**Returns**|Appened string|
|**Remarks**||
|||
|**Parameters**||
|_str_|Base string|
|_suffix_|String to append|

### Example
**Context**
``` json
{
    "a": "Lorem ipsum dolor sit amet",
    "b": ", consectetur adipiscing elit. Vivamus lacinia urna lectus."
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.Append a b}}
{{Helpers.String.Append a " or something"}}
{{Helpers.String.Append "something or" " another"}}
```
**Returns**
``` html
<strong>result:</strong>
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia urna lectus.
Lorem ipsum dolor sit amet or something
something or another
```

---
## Helpers.String.Ellipsis
|||
|-|-|
|**Summary**|Truncate a long string and append a ellipsis(...)|
|**Returns**|Truncated string|
|**Remarks**||
|||
|**Parameters**||
|_str_|String to trucate|
|_limit_|Max number of characters in final string(excluding ellipsis)|

### Example
**Context**
``` json
{
    "value": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia urna lectus."
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.Ellipsis value 10}}
{{Helpers.String.Ellipsis "something" 5}}
```
**Returns**
``` html
<strong>result:</strong>
Lorem ipsu...
somet...
```

---
## Helpers.String.Lowercase
|||
|-|-|
|**Summary**|Convert string to lowercase|
|**Returns**|Lowercase string|
|**Remarks**||
|||
|**Parameters**||
|_str_|input|

### Example
**Context**
``` json
{
    "value": "Some String WITH lots of UPPERCASE letters."
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.Lowercase value}}
{{Helpers.String.Lowercase "SOMETHING"}}
```
**Returns**
``` html
<strong>result:</strong>
some string with lots of uppercase letters.
something
```

---
## Helpers.String.Occurrences
|||
|-|-|
|**Summary**|Count number of times a substring appears in base string|
|**Returns**|Number of times string occurred|
|**Remarks**||
|||
|**Parameters**||
|_str_|Base string|
|_substring_|String to match|
|_ignoreCase_|Whether or not to ignore case, defaults to false|

### Example
**Context**
``` json
{
    "value": "Some string with multiple SubStrings.",
    "match": "string",
    "ignoreCase": true
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.Occurrences value match}}
{{Helpers.String.Occurrences value match ignoreCase}}
{{Helpers.String.Occurrences value "string"}}
{{Helpers.String.Occurrences value "string" true}}
{{Helpers.String.Occurrences "something somewhere" "some"}}
```
**Returns**
``` html
<strong>result:</strong>
1
2
1
2
2
```

---
## Helpers.String.Prepend
|||
|-|-|
|**Summary**|Prepend one string to another|
|**Returns**|Prepend string|
|**Remarks**||
|||
|**Parameters**||
|_str_|Base string|
|_prefix_|String to prepend|

### Example
**Context**
``` json
{
    "a": "Lorem ipsum dolor sit amet",
    "b": ", consectetur adipiscing elit. Vivamus lacinia urna lectus."
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.Prepend b a}}
{{Helpers.String.Prepend a "something or "}}
{{Helpers.String.Prepend "another" "something or "}}
```
**Returns**
``` html
<strong>result:</strong>
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia urna lectus.
something or Lorem ipsum dolor sit amet
something or another
```

---
## Helpers.String.Replace
|||
|-|-|
|**Summary**|Replace matching substrings within a string with something else.|
|**Returns**|Replaced string|
|**Remarks**|Not case-insensitive|
|||
|**Parameters**||
|_str_|Base string|
|_a_|String to match|
|_b_|Replacement

### Example
**Context**
``` json
{
    "value": "Some string with multiple Substrings.",
    "match": "string",
    "replacement": "value"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.Replace value match replacement}}
{{Helpers.String.Replace value match "test"}}
{{Helpers.String.Replace value "string" "test"}}
{{Helpers.String.Replace value "string" replacement}}
{{Helpers.String.Replace "something somewhere" "some" "test"}}
```
**Returns**
``` html
<strong>result:</strong>
Some value with multiple Subvalues.
Some test with multiple Subtests.
Some test with multiple Subtests.
Some value with multiple Subvalues.
testthing testwhere
```

---
## Helpers.String.Reverse
|||
|-|-|
|**Summary**|Reverse a string|
|**Returns**|Reversed string|
|**Remarks**||
|||
|**Parameters**||
|_str_|Input|

### Example
**Context**
``` json
{
    "value": "Some String WITH lots of UPPERCASE letters."
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.Reverse value}}
{{Helpers.String.Reverse "SOMETHING"}}
```
**Returns**
``` html
<strong>result:</strong>
.srettel ESACREPPU fo stol HTIW gnirtS emoS
GNIHTEMOS
```

---
## Helpers.String.Titlecase
|||
|-|-|
|**Summary**|Convert string to titlecase|
|**Returns**|Titlecase string|
|**Remarks**||
|||
|**Parameters**||
|_str_|input|

### Example
**Context**
``` json
{
    "value": "Some String WITH lots of UPPERCASE letters."
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.Titlecase value}}
{{Helpers.String.Titlecase "SOMETHING"}}
```
**Returns**
``` html
<strong>result:</strong>
Some String With Lots Of Uppercase Letters.
Something
```

---
## Helpers.String.Trim
|||
|-|-|
|**Summary**|Trim whitespace from left and right side of string|
|**Returns**|Trimmed string|
|**Remarks**||
|||
|**Parameters**||
|_str_|Base string|

### Example
**Context**
``` json
{
    "value": "      Some String WITH lots of UPPERCASE letters.      "
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.Trim value}}
{{Helpers.String.Trim "      SOMETHING      "}}
```
**Returns**
``` html
<strong>result:</strong>
Some String WITH lots of UPPERCASE letters.
SOMETHING
```

---
## Helpers.String.TrimLeft
|||
|-|-|
|**Summary**|Trim whitespace from left side of string|
|**Returns**|Trimmed string|
|**Remarks**||
|||
|**Parameters**||
|_str_|Base string|

### Example
**Context**
``` json
{
    "value": "      Some String WITH lots of UPPERCASE letters.      "
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.TrimLeft value}}
{{Helpers.String.TrimLeft "      SOMETHING      "}}
```
**Returns**
``` html
<strong>result:</strong>
Some String WITH lots of UPPERCASE letters.      
SOMETHING      
```

---
## Helpers.String.TrimRight
|||
|-|-|
|**Summary**|Trim whitespace from right side of string|
|**Returns**|Trimmed string|
|**Remarks**||
|||
|**Parameters**||
|_str_|Base string|

### Example
**Context**
``` json
{
    "value": "      Some String WITH lots of UPPERCASE letters.      "
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.TrimRight value}}
{{Helpers.String.TrimRight "      SOMETHING      "}}
```
**Returns**
``` html
<strong>result:</strong>
      Some String WITH lots of UPPERCASE letters.
      SOMETHING
```

---
## Helpers.String.Truncate
|||
|-|-|
|**Summary**|Truncate a long string and append a suffix(if set)|
|**Returns**|Truncated string|
|**Remarks**||
|||
|**Parameters**||
|_str_|String to trucate|
|_limit_|Max number of characters in final string(excluding suffix)|
|_suffix_|Suffix to append if string gets trucated|

### Example
**Context**
``` json
{
    "value": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia urna lectus."
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.Truncate value 10}}
{{Helpers.String.Truncate value 10 "..."}}
{{Helpers.String.Truncate "something" 5}}
{{Helpers.String.Truncate "something" 5 "test"}}
```
**Returns**
``` html
<strong>result:</strong>
Lorem ipsu
Lorem ipsu...
somet
somettest
```

---
## Helpers.String.TruncateWords
|||
|-|-|
|**Summary**|Truncate a long string and base truncation on the number of words instead of characters and append a suffix(if set)|
|**Returns**|Truncated string|
|**Remarks**||
|||
|**Parameters**||
|_str_|String to trucate|
|_limit_|Number of words in final string(excluding suffix)|
|_suffix_|Suffix to append if string gets trucated|

### Example
**Context**
``` json
{
    "value": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia urna lectus."
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.TruncateWords value 10}}
{{Helpers.String.TruncateWords value 10 "..."}}
{{Helpers.String.TruncateWords "something wicked this way comes" 2}}
{{Helpers.String.TruncateWords "something wicked this way comes" 2 "test"}}
```
**Returns**
``` html
<strong>result:</strong>
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia...
something wicked
something wickedtest
```

---
## Helpers.String.Uppercase
|||
|-|-|
|**Summary**|Convert string to uppercase|
|**Returns**|Uppercase string|
|**Remarks**||
|||
|**Parameters**||
|_str_|input|

### Example
**Context**
``` json
{
    "value": "Some String WITH lots of lowercase letters."
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.Lowercase value}}
{{Helpers.String.Lowercase "something"}}
```
**Returns**
``` html
<strong>result:</strong>
SOME STRING WITH LOTS OF LOWERCASE LETTERS.
SOMETHING
```

---
## Helpers.Url.Base64Decode
|||
|-|-|
|**Summary**|Base64 decode string|
|**Returns**|Decoded string|
|**Remarks**||
|||
|**Parameters**||
|_str_|Base64 encoded string to decode|

### Example
**Context**
``` json
{
    "value": "TG9yZW0gaXBzdW0gZG9sb3Igc2l0IGFtZXQsIGNvbnNlY3RldHVyIGFkaXBpc2NpbmcgZWxpdC4gVml2YW11cyBsYWNpbmlhIHVybmEgbGVjdHVzLg=="
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Url.Base64Decode value}}
{{Helpers.Url.Base64Decode "c29tZXRoaW5nIHdpY2tlZCB0aGlzIHdheSBjb21lcw=="}}
```
**Returns**
``` html
<strong>result:</strong>
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia urna lectus.
something wicked this way comes
```

---
## Helpers.Url.Base64Encode
|||
|-|-|
|**Summary**|Base64 encode string|
|**Returns**|Base64 encoded string|
|**Remarks**||
|||
|**Parameters**||
|_str_|String to Baes64 encode|

### Example
**Context**
``` json
{
    "value": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus lacinia urna lectus."
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Url.Base64Encode value}}
{{Helpers.Url.Base64Encode "something wicked this way comes"}}
```
**Returns**
``` html
<strong>result:</strong>
TG9yZW0gaXBzdW0gZG9sb3Igc2l0IGFtZXQsIGNvbnNlY3RldHVyIGFkaXBpc2NpbmcgZWxpdC4gVml2YW11cyBsYWNpbmlhIHVybmEgbGVjdHVzLg==
c29tZXRoaW5nIHdpY2tlZCB0aGlzIHdheSBjb21lcw==
```

---
## Helpers.Url.DecodeUri
|||
|-|-|
|**Summary**|Decode a uri encoded string|
|**Returns**|decoded string|
|**Remarks**||
|||
|**Parameters**||
|_str_|Uri encoded string|

### Example
**Context**
``` json
{
    "value": "arinet%2FHandlebarDocs%2Fblob%2Fmaster%2Fdocs%2Fhelpers.md%23helpersurldecodeuri"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Url.DecodeUri value}}
{{Helpers.Url.DecodeUri "%2Fsearch%2Finventory%2Fbrand%2FPolaris+Industries%2Fsort%2Fbest-match"}}
```
**Returns**
``` html
<strong>result:</strong>
arinet/HandlebarDocs/blob/master/helpers.md#helpersurldecodeuri
/search/inventory/brand/Polaris Industries/sort/best-match
```

---
## Helpers.Url.EncodeUri
|||
|-|-|
|**Summary**|Uri encode a string|
|**Returns**|Uri encoded string|
|**Remarks**||
|||
|**Parameters**||
|_str_|String to encode|

### Example
**Context**
``` json
{
    "value": "arinet/HandlebarDocs/blob/master/helpers.md#helpersurlencodeuri"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Url.EncodeUri value}}
{{Helpers.Url.EncodeUri "/search/inventory/brand/Polaris Industries/sort/best-match"}}
```
**Returns**
``` html
<strong>result:</strong>
arinet%2FHandlebarDocs%2Fblob%2Fmaster%2Fdocs%2Fhelpers.md%23helpersurlencodeuri
%2Fsearch%2Finventory%2Fbrand%2FPolaris+Industries%2Fsort%2Fbest-match
```

---
## Helpers.Url.StripProtocol
|||
|-|-|
|**Summary**|Remove protocol from url|
|**Returns**|Protocol free url|
|**Remarks**||
|||
|**Parameters**||
|_str_|Url to remove protocol from|

### Example
**Context**
``` json
{
    "value": "https://github.com/arinet/HandlebarDocs/blob/master/helpers.md#helpersurlstripprotocol"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Url.StripProtocol value}}
{{Helpers.Url.StripProtocol "https://www.duluthlawnandsport.com/s/search/inventory/brand/Polaris%20Industries/sort/best-match"}}
```
**Returns**
``` html
<strong>result:</strong>
//github.com/arinet/HandlebarDocs/blob/master/helpers.md#helpersurlstripprotocol
//www.duluthlawnandsport.com/s/search/inventory/brand/Polaris%20Industries/sort/best-match
```