# Custom Object Helpers
These helpers provide some ability to query and manage objects.

* [Helpers.Object.GetIndex](#helpersobjectgetindex)
* [Helpers.Object.GetLength](#helpersobjectgetlength)
* [Helpers.Object.ToJson](#helpersobjecttojson)

---
## Helpers.Object.GetIndex
|||
|-|-|
|**Summary**|Gets the index of an object in an array|
|**Returns**|The index of the object if found|
|**Remarks**|If input is not an array, this will return nothing|
|||
|**Parameters**||
|_input_|Array to get index of|
|_object_|Object to lookup index of|

### Example
**Context**
``` json
{
    "array": [
        "one",
        "two",
        "three"
    ]
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Object.GetIndex array "two"}}
{{Helpers.Object.GetIndex array "one"}}
```
**Returns**
``` html
<strong>result:</strong>
1
0
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
## Helpers.Object.ToJson
|||
|-|-|
|**Summary**|Gets a serilized json representation of the object passed in|
|**Returns**|Json object representing input|
|**Remarks**|If input is null, this will return null|
|||
|**Parameters**||
|_input_|Object to serialize|

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
{{Helpers.Object.ToJson d}}
```
**Returns**
``` html
<strong>result:</strong>
[{"id":1},{"id":2}]
```