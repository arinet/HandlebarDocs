# Custom Math Helpers
These helpers provide the ability to perform some calculations within a template.

* [Helpers.Math.Add](#helpersmathadd)
* [Helpers.Math.Ceiling](#helpersmathceiling)
* [Helpers.Math.Divide](#helpersmathdivide)
* [Helpers.Math.Floor](#helpersmathfloor)
* [Helpers.Math.Mod](#helpersmathmod)
* [Helpers.Math.Multiply](#helpersmathmultiply)
* [Helpers.Math.Round](#helpersmathround)
* [Helpers.Math.Subtract](#helpersmathsubtract)

---
## Helpers.Math.Add
|||
|-|-|
|**Summary**|Add two numbers|
|**Returns**|Sum of inputs|
|**Remarks**||
|||
|**Parameters**||
|_input1_|First input|
|_input2_|Second input|

### Example
**Context**
``` json
{
    "a": 1,
    "b": 2,
    "c": 3
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Add a b}}
{{Helpers.Math.Add b c}}
{{Helpers.Math.Add c 4}}
{{Helpers.Math.Add 4 5}}
```
**Returns**
``` html
<strong>result:</strong>
3
5
7
9
```

---
## Helpers.Math.Ceiling
|||
|-|-|
|**Summary**|Rounds input up to the nearest whole number|
|**Returns**|Ceiling of input|
|**Remarks**||
|||
|**Parameters**||
|_input_|input|

### Example
**Context**
``` json
{
    "a": 1.23,
    "b": 2.45,
    "c": 3.67
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Ceiling a}}
{{Helpers.Math.Ceiling b}}
{{Helpers.Math.Ceiling c}}
{{Helpers.Math.Ceiling 4.89}}
```
**Returns**
``` html
<strong>result:</strong>
2
3
4
5
```

---
## Helpers.Math.Divide
|||
|-|-|
|**Summary**|Divide first input by second input|
|**Returns**|Result of first input divided by second input|
|**Remarks**||
|||
|**Parameters**||
|_input1_|First input|
|_input2_|Second input|

### Example
**Context**
``` json
{
    "a": 1,
    "b": 2,
    "c": 3
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Divide a b}}
{{Helpers.Math.Divide b c}}
{{Helpers.Math.Divide c 4}}
{{Helpers.Math.Divide 4 5}}
```
**Returns**
``` html
<strong>result:</strong>
0.5
0.666666666666667
0.75
0.8
```

---
## Helpers.Math.Floor
|||
|-|-|
|**Summary**|Rounds input down to the nearest whole number|
|**Returns**|Floor of input|
|**Remarks**||
|||
|**Parameters**||
|_input_|input|

### Example
**Context**
``` json
{
    "a": 1.23,
    "b": 2.45,
    "c": 3.67
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Floor a}}
{{Helpers.Math.Floor b}}
{{Helpers.Math.Floor c}}
{{Helpers.Math.Floor 4.89}}
```
**Returns**
``` html
<strong>result:</strong>
1
2
3
4
```

---
## Helpers.Math.Mod
|||
|-|-|
|**Summary**|Modulus of first over second input|
|**Returns**|Result of modulus of first input over second input|
|**Remarks**||
|||
|**Parameters**||
|_input1_|First input|
|_input2_|Second input|

### Example
**Context**
``` json
{
    "a": 1,
    "b": 2,
    "c": 3
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Mod a b}}
{{Helpers.Math.Mod b c}}
{{Helpers.Math.Mod c 4}}
{{Helpers.Math.Mod 4 5}}
```
**Returns**
``` html
<strong>result:</strong>
1
2
3
4
```

---
## Helpers.Math.Multiply
|||
|-|-|
|**Summary**|Multiply first input by second input|
|**Returns**|Result of multiplication of first input and second input|
|**Remarks**||
|||
|**Parameters**||
|_input1_|First input|
|_input2_|Second input|

### Example
**Context**
``` json
{
    "a": 1,
    "b": 2,
    "c": 3
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Multiply a b}}
{{Helpers.Math.Multiply b c}}
{{Helpers.Math.Multiply c 4}}
{{Helpers.Math.Multiply 4 5}}
```
**Returns**
``` html
<strong>result:</strong>
2
6
12
20
```

---
## Helpers.Math.Round
|||
|-|-|
|**Summary**|Rounds input to the nearest whole number|
|**Returns**|Rounded input|
|**Remarks**|Rounds depending on what side of the half the number falls on|
|||
|**Parameters**||
|_input_|input|

### Example
**Context**
``` json
{
    "a": 1.23,
    "b": 2.45,
    "c": 3.67
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Round a}}
{{Helpers.Math.Round b}}
{{Helpers.Math.Round c}}
{{Helpers.Math.Round 4.89}}
```
**Returns**
``` html
<strong>result:</strong>
1
2
4
5
```

---
## Helpers.Math.Subtract
|||
|-|-|
|**Summary**|Subtract second input from first|
|**Returns**|Result of subtracting the second input from first|
|**Remarks**||
|||
|**Parameters**||
|_input1_|First input|
|_input2_|Second input|

### Example
**Context**
``` json
{
    "a": 4,
    "b": 3,
    "c": 1
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{Helpers.Math.Subtract a b}}
{{Helpers.Math.Subtract b c}}
{{Helpers.Math.Subtract c 2}}
{{Helpers.Math.Subtract 2 5}}
```
**Returns**
``` html
<strong>result:</strong>
1
2
-1
-3
```