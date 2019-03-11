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
|_flags_|_(Optional)_ Flags to apply to match.

### Example
**Context**
``` json
{
    "value": "https://github.com/arinet/HandlebarDocs/blob/master/customHelpers.md"
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

### Supported Flags ###

* **IgnoreCase**

  By default, regular expressions are matched against strings case-sensitively:

  **Context**
  ``` json
  {
    "lower": "abc",
    "upper": "ABC"
  }
  ```
  **Usage**
  ``` handlebars
  <strong>result:</strong>
  {{#Helpers.Regex.IsMatch lower "abc"}}
      <strong>True</strong>
  {{else}}
      <strong>False</strong>
  {{/Helpers.Regex.IsMatch}}
  {{#Helpers.Regex.IsMatch upper "abc"}}
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
  ```

  If you specify IgnoreCase, both input strings (abc and ABC) will be matched by the pattern abc:

  ``` handlebars
  <strong>result:</strong>
  {{#Helpers.Regex.IsMatch upper "abc" "i"}}
      <strong>True</strong>
  {{else}}
      <strong>False</strong>
  {{/Helpers.Regex.IsMatch}}
  ```

  **Returns**
  ``` html
  <strong>result:</strong>
  <strong>True</strong>
  ```

  It's especially handy to use the RegexOptions.IgnoreCase flag when using character classes: [a-zA-Z] can then be shortened to [a-z]. If you need to do a case-insensitive match, specifying this flag helps you write clearer, shorter, and more readable patterns.

* **Multiline**

  The Multiline flag changes the meaning of the special characters ^ and $. Usually, they match at the beginning (^) and the end ($) of the entire string. With Multiline applied, they match at the beginning or end of any line of the input string.

  Here's how you could use Multiline to check whether some multi-line string (e.g. from a text file) contains a line that only consists of digits:

  **Context**
  ``` json
  {
    "input": "abc\n123"
  }
  ```
  **Usage**
  ``` handlebars
  <strong>result:</strong>
  {{#Helpers.Regex.IsMatch input "^\d+$"}}
      <strong>True</strong>
  {{else}}
      <strong>False</strong>
  {{/Helpers.Regex.IsMatch}}
  {{#Helpers.Regex.IsMatch input "^\d+$" "m"}}
      <strong>True</strong>
  {{else}}
      <strong>False</strong>
  {{/Helpers.Regex.IsMatch}}
  ```

  **Returns**
  ``` html
  <strong>result:</strong>
  <strong>False</strong>
  <strong>True</strong>
  ```

* **Singleline**

  Singleline changes the meaning of the dot (.), which matches every character except \n. With the Singleline flag set, the dot will match every character.

  Sometimes, you'll see people use a pattern like [\d\D] to mean "any character". Such a pattern is a tautology, that is, it's universally true — every character will either be or not be a digit. It has the same behavior as the dot with Singleline specified.

  **Context**
  ``` json
  {
    "input": "abc\n123"
  }
  ```
  **Usage**
  ``` handlebars
  <strong>result:</strong>
  {{#Helpers.Regex.IsMatch input ".123"}}
      <strong>True</strong>
  {{else}}
      <strong>False</strong>
  {{/Helpers.Regex.IsMatch}}
  {{#Helpers.Regex.IsMatch input ".123" "s"}}
      <strong>True</strong>
  {{else}}
      <strong>False</strong>
  {{/Helpers.Regex.IsMatch}}
  ```

  **Returns**
  ``` html
  <strong>result:</strong>
  <strong>False</strong>
  <strong>True</strong>
  ```

---
## Note: 
1. Regex flags can be combined to match the desired effect. For instance, you could combine the IgnoreCase and Multiline flags by passing in `"im"` or `"mi"`.  If you wanted to pass in all flags, you could do so by passing in `"ims"`.