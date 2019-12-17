# Custom Path Helpers
These helpers provide the ability to parse paths.

* [Helpers.Path.GetAbsolutePath](#helperspathgetabsolutepath)
* [Helpers.Path.GetDirectory](#helperspathgetdirectory)
* [Helpers.Path.GetExtension](#helperspathgetextension)
* [Helpers.Path.GetFilename](#helperspathgetfilename)

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
{{Helpers.Path.GetAbsolutePath "arinet/HandlebarDocs/blob/master/customHelpers.md"}}
```
**Returns**
``` html
<strong>result:</strong>
/first/second/third
_first_second_third
/arinet/HandlebarDocs/blob/master
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
{{Helpers.Path.GetDirectory "arinet/HandlebarDocs/blob/master/customHelpers.md"}}
```
**Returns**
``` html
<strong>result:</strong>
third
third
master
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
{{Helpers.Path.GetExtension "arinet/HandlebarDocs/blob/master/customHelpers.md"}}
```
**Returns**
``` html
<strong>result:</strong>
.txt
.txt
.md
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
{{Helpers.Path.GetFilename "arinet/HandlebarDocs/blob/master/customHelpers.md"}}
```
**Returns**
``` html
<strong>result:</strong>
somefile.txt
somefile.txt
helpers.md
```