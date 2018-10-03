# Custom Object Helpers
These helpers provide some ability to query and manage objects.

* [Helpers.Object.GetLength](#helpersobjectgetlength)

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