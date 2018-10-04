# Custom HTML Helpers
These helpers provide some ability to manage strings for use within html content.

* [Helpers.Html.Escape](#helpershtmlescape)
* [Helpers.Html.HtmlDecode](#helpershtmlhtmldecode)
* [Helpers.Html.HtmlEncode](#helpershtmlhtmlencode)

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
    "value": "https://github.com/arinet/HandlebarDocs/blob/master/html.md#helpershtmlescape"
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
https:\/\/github.com\/arinet\/HandlebarDocs\/blob\/master\/docs\/html.md#helpershtmlescape
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