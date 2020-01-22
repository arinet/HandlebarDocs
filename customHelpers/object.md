# Custom Object Helpers
These helpers provide some ability to query and manage objects.

* [Helpers.Object.GetIndex](#helpersobjectgetindex)
* [Helpers.Object.GetLength](#helpersobjectgetlength)
* [Helpers.Object.Max](#helpersobjectmax)
* [Helpers.Object.Min](#helpersobjectmin)
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
## Helpers.Object.Max
|||
|-|-|
|**Summary**|Returns the maximum value of a property inside of an array of objects|
|**Returns**|The maximum value found|
|**Remarks**|If input is not an array, this will return nothing|
||If no property is passed in, this will return the maximum value of the array that is passed in|
|||
|**Parameters**||
|_input_|Array to search|
|_property_|Property to match on|

### Example 1
**Context**
``` json
{
    "array": [
        1,
        2,
        3
    ]
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Object.Max array}}
```
**Returns**
``` html
<strong>result:</strong>
3
```

### Example 2
**Context**
``` json
{
    "array": [
        {
            "id": 1,
            "name": "test1",
            "type": {
                "id": 4,
                "name": "type1"
            }
        },
        {
            "id": 2,
            "name": "test2",
            "type": {
                "id": 5,
                "name": "type2"
            }
        },
        {
            "id": 3,
            "name": "test3",
            "type": {
                "id": 6,
                "name": "type3"
            }
        }
    ]
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Object.Max array "id"}}
{{Helpers.Object.Max array "type.id"}}
{{Helpers.Object.Max array "type.name"}}
```
**Returns**
``` html
<strong>result:</strong>
3
6
type3
```

---
## Helpers.Object.Min
|||
|-|-|
|**Summary**|Returns the minimum value of a property inside of an array of objects|
|**Returns**|The minimum value found|
|**Remarks**|If input is not an array, this will return nothing|
||If no property is passed in, this will return the minimum value of the array that is passed in|
|||
|**Parameters**||
|_input_|Array to search|
|_property_|Property to match on|

### Example 1
**Context**
``` json
{
    "array": [
        1,
        2,
        3
    ]
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Object.Min array}}
```
**Returns**
``` html
<strong>result:</strong>
1
```

### Example 2
**Context**
``` json
{
    "array": [
        {
            "id": 1,
            "name": "test1",
            "type": {
                "id": 4,
                "name": "type1"
            }
        },
        {
            "id": 2,
            "name": "test2",
            "type": {
                "id": 5,
                "name": "type2"
            }
        },
        {
            "id": 3,
            "name": "test3",
            "type": {
                "id": 6,
                "name": "type3"
            }
        }
    ]
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Object.Min array "id"}}
{{Helpers.Object.Min array "type.id"}}
{{Helpers.Object.Min array "type.name"}}
```
**Returns**
``` html
<strong>result:</strong>
1
4
type1
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