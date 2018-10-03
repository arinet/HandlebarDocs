# Custom Number Helpers
These helpers allow you to manipulate numbers.

* [Helpers.Number.FormatPrice](#helpersnumberformatprice)

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