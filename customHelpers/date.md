# Custom Date Helpers
These helpers provide some ability to manage date and time data.

* [Helpers.Date.Format](#helpersdateformat)

---
## Helpers.Date.Format
|||
|-|-|
|**Summary**|Generate a formatted date string|
|**Returns**|Formatted datetime if possible, otherwise the input|
|**Remarks**||
|||
|**Parameters**||
|_input_|Input string to try formatting|
|_format_|A [standard](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings) or [custom](https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings) date and time format string|

### Example
**Context**
``` json
{
    "datetime": "2019-03-12T15:45:00Z"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Date.Format datetime "MMM. d yyyy"}}
{{Helpers.Date.Format datetime "MM/dd/yyyy"}}
```
**Returns**
``` html
<strong>result:</strong>
Mar. 12 2019
03/12/2019
```
