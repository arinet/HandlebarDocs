# Custom Url Helpers
These helpers provide some ability to manage strings for use within a url.

* [Helpers.Url.Base64Decode](#helpersurlbase64decode)
* [Helpers.Url.Base64Encode](#helpersurlbase64encode)
* [Helpers.Url.DecodeUri](#helpersurldecodeuri)
* [Helpers.Url.EncodeUri](#helpersurlencodeuri)
* [Helpers.Url.StripProtocol](#helpersurlstripprotocol)

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