# Custom Regex Block Helpers
These block helpers allow for performing regex operations on strings

* [Helpers.Regex.IsMatch](#helpersregexismatch)

---
## Helpers.Regex.IsMatch
|||
|-|-|
|**Summary**|Determine if regex pattern matches on string|
|**Returns**|Whether or not a match was found|
|**Remarks**||
|||
|**Parameters**||
|_str_|Input|
|_pattern_|Regex pattern|

### Example
**Context**
``` json
{
    "value": "https://github.com/arinet/HandlebarDocs/blob/master/helpers.md"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.Regex.IsMatch value "(blob|master|test)"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Regex.IsMatch}}

{{#Helpers.Regex.IsMatch value "/d+/"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Regex.IsMatch}}

{{#Helpers.Regex.IsMatch value "ari[^n]"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Regex.IsMatch}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>True</strong>

<strong>False</strong>

<strong>False</strong>
```