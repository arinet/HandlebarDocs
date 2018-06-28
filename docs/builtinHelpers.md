# Built-in Helpers
Contents of this document were more or less copied from here [http://handlebarsjs.com/builtin_helpers.html](http://handlebarsjs.com/builtin_helpers.html).  The resulting document is tailored to our implmentation.

* [if](#if)
* [unless](#unless)
* [each](#each)
* [with](#with)

---
## if
The `if` block helper will conditionally render a block if the resulting condition returns true, 1, or is a non-empty array. Inversely, it will not render the block if its argument returns false, undefined, null, "", 0, or [].

**Context**
``` json
{
    "value": "test",
    "someObject": true
}
```

**Usage**
``` handlebars
<ul>
    <li>
        {{#if value}}
            <span>value exists</span>
        {{else}}
            <span>value does not exist</span>
        {{/if}}
    </li>
    <li>
        {{#if someObject}}
            <span>someObject is true</span>
        {{else}}
            <span>someObject is false</span>
        {{/if}}
    </li>
    <li>
        {{#if somethingThatDoesntExist}}
            <span>somethingThatDoesntExist exists</span>
        {{else}}
            <span>somethingThatDoesntExist does not exist</span>
        {{/if}}
    </li>
</ul>
```

**Result**
``` html
<ul>
    <li>
        <span>value exists</span>
    </li>
    <li>
        <span>someObject is true</span>
    </li>
    <li>
        <span>somethingThatDoesntExist does not exist</span>
    </li>
</ul>
```

Additionally, you can chain conditions to perform if, else if, else.
**Usage**
``` handlebars
{{#if value}}
    <span>value exists</span>
{{else if someObject}}
    <span>someObject is true</span>
{{else}}
    <span>value does not exists and someObject is false</span>
{{/if}}
```

**Result**
``` html
<span>value exists</span>
```

### **Note**:
You'll notice that none of these examples are demonstrating how you can perform logical conditions; things like `if value = "test"`. That is because handlebars `if` block helper is only concerned if the argument passed in is itself truthy. If you want to do more complex logic, you'll need to explore our custom [helpers](customHelpers.md) and [block helpers](customBlockHelpers.md). 

---
## unless
The `unless` block helper is the inverse of the `if` helper.  It will render in the case when the argument returns false, undefined, null, "", 0, or [] and will not render if the argument returns true, 1, or is a non-empty array.

**Context**
``` json
{
    "value": "test",
    "someObject": true
}
```

**Usage**
``` handlebars
<ul>
    <li>
        {{#unless value}}
            <span>value does not exist</span>
        {{else}}
            <span>value exists</span>
        {{/unless}}
    </li>
    <li>
        {{#unless someObject}}
            <span>someObject is false</span>
        {{else}}
            <span>someObject is true</span>
        {{/unless}}
    </li>
    <li>
        {{#unless somethingThatDoesntExist}}
            <span>somethingThatDoesntExist does not exist</span>
        {{else}}
            <span>somethingThatDoesntExist exists</span>
        {{/unless}}
    </li>
</ul>
```

**Result**
``` html
<ul>
    <li>
        <span>value exists</span>
    </li>
    <li>
        <span>someObject is true</span>
    </li>
    <li>
        <span>somethingThatDoesntExist does not exist</span>
    </li>
</ul>
```

---
## each
The `each` block helper will iterate over and array or an object.  The rendered block will be called for each iteration and the resulting context of each iteration will be the current element in the loop.

**Context**
``` json
{
    "someObject": {
        "id": 1,
        "name": "object"
    },
    "array": [
        1,
        2,
        3
    ]
}
```

**Usage**
``` handlebars
<ul>
    {{#each someObject}}
        <li>{{@key}}: {{this}}</li>
    {{/each}}
</ul>
<ul>
    {{#each array}}
        <li>{{this}}</li>
    {{/each}}
</ul>
```

**Result**
``` html
<ul>
    <li>id: 1</li>
    <li>name: object</li>
</ul>
<ul>
    <li>1</li>
    <li>2</li>
    <li>3</li>
</ul>
```

---
## with
The `with` block helper will set the current context ([this](dataVariables.md#this)) to the object you pass in.

**Context**
``` json
{
    "value": "test",
    "someObject": {
        "id": 1,
        "name": "object"
    }
}
```

**Usage**
``` handlebars
<div>
    <span>{{value}}</span>
    <ul>
        {{#with someObject}}
            <li>{{id}}</li>
            <li>{{@name}}</li>
        {{/with}}
    </ul>
</div>
```

**Result**
``` html
<div>
    <span>test</span>
    <ul>
        <li>1</li>
        <li>object</li>
    </ul>
</div>
```
