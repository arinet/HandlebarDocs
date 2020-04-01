# Custom Date Helpers
These helpers provide some ability to manage date and time data.

* [Helpers.Date.Format](#helpersdateformat)
* [Helpers.Date.Today](#helpersdatetoday)

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
---
## Helpers.Date.Today
|||
|-|-|
|**Summary**|Output formatted current date string using the specified time zone id, default format "MM/dd/yyyy"
|**Returns**|Formatted current date|
|**Remarks**||
|||
|**Parameters**||
|_format_|A [standard](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings) or [custom](https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings) date and time format string|
|_timeZoneName_|[Time Zone Name](https://support.microsoft.com/en-in/help/973627/microsoft-time-zone-index-values) e.g. "Eastern Standard Time"|
### Example

**Usage**
``` handlebars
<strong>result (assuming local date time as 12-Mar-2019 09:00:00 AM [India Standard Time]):</strong>
1: {{Helpers.Date.Today}}
2: {{Helpers.Date.Today "MM/dd/yyyy"}}
3: {{Helpers.Date.Today "MMM. d yyyy"}}
4: {{Helpers.Date.Today "yyyy-MM-ddTHH:mm:ssZ"}}
5: {{Helpers.Date.Today "MM/dd/yyyy" "Eastern Standard Time"}}
6: {{Helpers.Date.Today "MM/dd/yyyy" "UTC"}}
7: {{Helpers.Date.Today "MM/dd/yyyy" "Invalid Time Zone"}}

```
**Returns**
``` html
<strong>result (assuming local date time as 12-Mar-2019 09:00:00 AM [India Standard Time]):</strong>
1: 03/12/2019
2: 03/12/2019
3: Mar. 12 2019
4: 2019-03-12T00:00:00Z
5: 03/11/2019
6: 03/12/2019
7: 03/12/2019
```
