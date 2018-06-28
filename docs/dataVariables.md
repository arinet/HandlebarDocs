# Built-in Variables
Contents of this document were more or less copied from here [http://handlebarsjs.com/reference.html](http://handlebarsjs.com/reference.html).  The resulting document is tailored to our implmentation.

* [@root](#root)
* [@first](#first)
* [@last](#last)
* [@index](#index)
* [@key](#key)
* [this](#this)

---
## @root
`@root` returns the initial context.  You can use this, when you're nested inside block helpers, to gain access to objects in the original context.

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
            <li>{{name}}</li>
            <li>{{@root.value}}</li>
        {{/with}}
    </ul>
</div>
```

**Result**
``` html
<div>
    <span>test</span>
    <ul>
        <li>object</li>
        <li>test</li>
    </ul>
</div>
```

---
## @first
`@first` will return true if the current iteration of a loop is the first.

**Context**
``` json
{
    "array": [
        {
            "id": 1
        },
        {
            "id": 2
        },
        {
            "id": 3
        }
    ]
}
```

**Usage**
``` handlebars
<ul>
    {{#each array}}
        <li>
            <span>{{id}}: </span>
            {{#if @first}}
                <span>First</span>
            {{else}}
                <span>Not First</span>
            {{/if}}
        </li>
    {{/each}}
</ul>
```

**Result**
``` html
<ul>
    <li>
        <span>1: </span>
        <span>First</span>
    </li>
    <li>
        <span>2: </span>
        <span>Not First</span>
    </li>
    <li>
        <span>3: </span>
        <span>Not First</span>
    </li>
</ul>
```

---
## @last
`@last` will return true if the current iteration of a loop is the first.

**Context**
``` json
{
    "array": [
        {
            "id": 1
        },
        {
            "id": 2
        },
        {
            "id": 3
        }
    ]
}
```

**Usage**
``` handlebars
<ul>
    {{#each array}}
        <li>
            <span>{{id}}: </span>
            {{#if @last}}
                <span>Last</span>
            {{else}}
                <span>Not Last</span>
            {{/if}}
        </li>
    {{/each}}
</ul>
```

**Result**
``` html
<ul>
    <li>
        <span>1: </span>
        <span>Not Last</span>
    </li>
    <li>
        <span>2: </span>
        <span>Not Last</span>
    </li>
    <li>
        <span>3: </span>
        <span>Last</span>
    </li>
</ul>
```

---
## @index
`@index` will return the current index of the array when iterating over a loop.

**Context**
``` json
{
    "array": [
        {
            "id": 1
        },
        {
            "id": 2
        },
        {
            "id": 3
        }
    ]
}
```

**Usage**
``` handlebars
<ul>
    {{#each array}}
        <li>
            <span>{{id}}: </span>
            <span>{{@index}}</span>
        </li>
    {{/each}}
</ul>
```

**Result**
``` html
<ul>
    <li>
        <span>1: </span>
        <span>0</span>
    </li>
    <li>
        <span>2: </span>
        <span>1</span>
    </li>
    <li>
        <span>3: </span>
        <span>2</span>
    </li>
</ul>
```

---
## @key
`@key` returns the property name of the current context.  You'd typically use this when looping over an object.

**Context**
``` json
{
    "someObject": {
        "id": 1,
        "name": "object"
    }
}
```

**Usage**
``` handlebars
<ul>
    {{#each someObject}}
        <li>{{@key}}</li>
    {{/each}}
</ul>
```

**Result**
``` html
<ul>
    <li>id</li>
    <li>name</li>
</ul>
```

---
## this
`this` returns the current context. You can use it to explore the current [path](otherFunctionality.md#paths) or to return the current value of the current context.

**Context**
``` json
{
    "value": "test",
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

1. ### Path Exploration
    **Usage**
    ``` handlebars
    <div>
        <span>{{value}}</span>
        <ul>
            {{#with someObject}}
                <li>{{name}}</li>
                <li>{{this/../value}}</li>
            {{/with}}
        </ul>
    </div>
    ```

    **Result**
    ``` html
    <div>
        <span>test</span>
        <ul>
            <li>object</li>
            <li>test</li>
        </ul>
    </div>
    ```

2. ### Array Context
    **Usage**
    ``` handlebars
    <ul>
        {{#each array}}
            <li>{{this}}</li>
        {{/each}}
    </ul>
    ```

    **Result**
    ``` html
    <ul>
        <li>1</li>
        <li>2</li>
        <li>3</li>
    </ul>
    ```

3. ### Object Context
    **Usage**
    ``` handlebars
    <ul>
        {{#each someObject}}
            <li>{{this}}</li>
        {{/each}}
    </ul>
    ```

    **Result**
    ``` html
    <ul>
        <li>1</li>
        <li>object</li>
    </ul>
    ```