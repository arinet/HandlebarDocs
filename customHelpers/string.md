# Custom String Helpers
These helpers provide some ability to do string manipulation.

* [Helpers.String.Append](#helpersstringappend)
* [Helpers.String.Ellipsis](#helpersstringellipsis)
* [Helpers.String.Join](#helpersstringjoin)
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
* [Helpers.String.PadLeft](#helpersstringpadleft)
* [Helpers.String.PadRight](#helpersstringpadright)

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
## Helpers.String.Join
|||
|-|-|
|**Summary**|Join multiple strings together separated by the specified separator|
|**Returns**|Joined string|
|**Remarks**|Can be passed either an array of strings or a set of strings as arguments|
|||
|**Parameters**||
|_strArray_|strings to join|
|_separator_|Separator to used to delimit strings, default is an empty string|

### Example
**Context**
``` json
{
    "stringArray": [
        "Lorem",
        "ipsum",
        "dolor",
        "sit",
        "amet"
    ]
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.String.Join stringArray " "}}
{{Helpers.String.Join stringArray}}
{{Helpers.String.Join "Lorem" "ipsum" "dolor" "sit" "amet" " "}}
{{Helpers.String.Join "Lorem" "ipsum" "dolor" "sit" "amet" ""}}
{{Helpers.String.Join "Lorem" "ipsum" "dolor" "sit" "amet"}}
```
**Returns**
``` html
<strong>result:</strong>
Lorem ipsum dolor sit amet
Loremipsumdolorsitamet
Lorem ipsum dolor sit amet
Loremipsumdolorsitamet
Loremametipsumametdolorametsit
```

> **NOTE:** The last call in the examples, if you pass in multiple strings instead of a string array, and there are more than **two** strings passed in, it treats the final string as the separator/delimiator. This means that if you tried
`{{Helpers.String.Join "Lorem" "ipsum" "dolor" "sit" "amet"}}` and wanted to get back `Loremipsumdolorsitamet`, then you would actually need to add one more string to your list; ex: `{{Helpers.String.Join "Lorem" "ipsum" "dolor" "sit" "amet" ""}}`



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
## Helpers.String.PadLeft
|||
|-|-|
|**Summary**|Pad left input string with the padding character for a specified total length.|
|**Returns**|Left padded string|
|**Remarks**||
|||
|**Parameters**||
|_str_|Base string|
|_totalWidth_|The number of characters in the resulting string|
|_paddingChar_|Padding character (not more than 1)|

### Example
**Context**
``` json
{
    "value": "pad-me"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
1. {{Helpers.String.PadLeft value 10 "0"}}
2. {{Helpers.String.PadLeft value "10" "0"}}
3. {{Helpers.String.PadLeft "custom-string" 15 "0"}}
4. {{Helpers.String.PadLeft value 15 "more-than-1-chars"}}
5. {{Helpers.String.PadLeft "custom-string" 15 "more-than-1-chars"}}
```
**Returns**
``` html
<strong>result:</strong>
1. 0000pad-me
2. 0000pad-me
3. 000custom-string
4. pad-me
5. custom-string

```
---
## Helpers.String.RightLeft
|||
|-|-|
|**Summary**|Pad right input string with the padding character for a specified total length.|
|**Returns**|Left padded string|
|**Remarks**||
|||
|**Parameters**||
|_str_|Base string|
|_totalWidth_|The number of characters in the resulting string|
|_paddingChar_|Padding character (not more than 1)|

### Example
**Context**
``` json
{
    "value": "pad-me"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
1. {{Helpers.String.PadRight value 10 "0"}}
2. {{Helpers.String.PadRight value "10" "0"}}
3. {{Helpers.String.PadRight "custom-string" 15 "0"}}
4. {{Helpers.String.PadRight value 15 "more-than-1-chars"}}
5. {{Helpers.String.PadRight "custom-string" 15 "more-than-1-chars"}}
```
**Returns**
``` html
<strong>result:</strong>
1. pad-me0000
2. pad-me0000
3. custom-string000
4. pad-me
5. custom-string

```
