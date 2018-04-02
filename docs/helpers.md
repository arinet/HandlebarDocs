## Helpers.Html.Escape
### Summary
Javascript escape a string
### Returns
Escaped string
### Parameters
* str: String to escape

## Helpers.Html.HtmlDecode
### Summary
Decode html encoded string
### Returns
Decoded string
### Parameters
* html: String to decode

## Helpers.Html.HtmlEncode
### Summary
Html encode string
### Returns
Html encoded string
### Parameters
* html: String to encode

## Helpers.Math.Add
### Summary
Add two numbers
### Returns
Sum of inputs
### Parameters
* input1: First input
* input2: Second input

## Helpers.Math.Ceiling
### Summary
Ceiling of input
### Returns
Ceiling of input
### Parameters
* input: Input

## Helpers.Math.Divide
### Summary
Divide first input by second input
### Returns
Divided inputs
### Parameters
* input1: First input
* input2: Second input

## Helpers.Math.Floor
### Summary
Floor of input
### Returns
Floor of input
### Parameters
* input: Input

## Helpers.Math.Mod
### Summary
Modulus of first over second input
### Returns
Modulus of inputs
### Parameters
* input1: First input
* input2: Second input

## Helpers.Math.Multiply
### Summary
Multiply two numbers
### Returns
Multiplied inputs
### Parameters
* input1: First input
* input2: Second input

## Helpers.Math.Round
### Summary
Rounded input
### Returns
Rounded input
### Parameters
* input: Input

## Helpers.Math.Subtract
### Summary
Subtract second input from first
### Returns
Subtraction of inputs
### Parameters
* input1: First input
* input2: Second input

## Helpers.Number.FormatPrice
### Summary
Format number as price
### Returns
Formatted price
### Parameters
* number: Number to format

## Helpers.Object.Compare
### Summary
Compare two objects
### Returns
Whether or not operation evaluates successfully
### Parameters
* lvalue: Left object
* rvalue: Right object
* operatorType: Operator to perform

## Helpers.Object.GetLength
### Summary
Gets the length of an array
### Returns
Size of array
### Parameters
* input: Array to get length of

## Helpers.Object.Lookup
### Summary
Pull object by key or index from a dynamic object or list/array
### Returns
Object that is found
### Parameters
* input: Object/list/array to pull from
* lookup: key/index to look for

## Helpers.Path.GetAbsolutePath
### Summary
Given path, get just the folder paths
### Returns
Folder paths
### Example
```
/first/second/third/somefile.txt
            would return
            /first/second/third
```
### Parameters
* path: Path to pull info from
* delimiter: Delimiter to parse path with

## Helpers.Path.GetDirectory
### Summary
Given path, get top level directory name
### Returns
Top level directory name
### Example
```
/first/second/third/somefile.txt
            would return
            third
```
### Parameters
* path: Path to pull info from
* delimiter: Delimiter to parse path with

## Helpers.Path.GetExtension
### Summary
Given path, get file extension
### Returns
File extension
### Example
```
/first/second/third/somefile.txt
            would return
            txt
```
### Parameters
* path: Path to pull info from
* delimiter: Delimiter to parse path with

## Helpers.Path.GetFilename
### Summary
Given path, get file name
### Returns
File name
### Example
```
/first/second/third/somefile.txt
            would return
            somefile.txt
```
### Parameters
* path: Path to pull info from
* delimiter: Delimiter to parse path with

## Helpers.Path.GetKeyValuePairMatches
### Summary
Given path, determine if key and value exist
### Returns
Returns matching records
### Example
```
path = /k1/v1/k2/v2/k3/v3 
            keyValuePairs = {"key":"k2", "values": ["v2", "v3"]}
            would return
            the keyValuePairs parameter
```
### Parameters
* path: Path to pull info from
* keyValuePairs: List of key value pairs
* delimiter: Delimiter to parse path with
* offset: Offset to start key/value pair loading

## Helpers.Path.HasExtension
### Summary
Given path, get whether or not it contains a file extension
### Returns
Whether or not it contains a file extension
### Example
```
/first/second/third/somefile.txt
            would return
            True
```
### Parameters
* path: Path to pull info from
* extension: extension to look for

## Helpers.Path.HasKeyValuePairMatch
### Summary
Given path, determine if key and value exist
### Returns
Whether or not key and value exist
### Example
```
path = /k1/v1/k2/v2/k3/v3 
            key = k2
            vlue = v2
            would return
            True
```
### Parameters
* path: Path to pull info from
* key: Key to look for
* value: Value to look for
* delimiter: Delimiter to parse path with
* offset: Offset to start key/value pair loading

## Helpers.Path.HasSegment
### Summary
Given path, determine if segment exists
### Returns
Whether or not segment exists
### Example
```
path = /k1/v1/k2/v2/k3/v3 
            segment = k2
            would return
            True
```
### Parameters
* path: Path to pull info from
* segment: segment to look for
* delimiter: Delimiter to parse path with

## Helpers.Path.ParseUnitSlug
### Summary
Given a bigInteger url slug, parse out the values
### Returns
object representing parsed values
### Parameters
* path: Path to pull info from

## Helpers.Regex.IsMatch
### Summary
Determine if regex pattern matches on string
### Returns
Whether or not a match was found
### Parameters
* str: Input
* pattern: Regex pattern

## Helpers.String.Append
### Summary
Append one string to another
### Returns
Appened string
### Parameters
* str: Base string
* suffix: String to append

## Helpers.String.Contains
### Summary
Determine if the string contains a substring
### Returns
Whether or not string contains substring
### Parameters
* str: Base string
* match: String to match
* ignoreCase: Whether or not to ignore case

## Helpers.String.Ellipsis
### Summary
Truncate a long string and append a ellipsis(...)
### Returns
Truncated string
### Parameters
* str: String to trucate
* limit: Max number of characters in final string(excluding ellipsis)

## Helpers.String.EndsWith
### Summary
Determine if the string ends with a substring
### Returns
Whether or not the string ends with substring
### Parameters
* str: Base string
* suffix: String to match
* ignoreCase: Whether or not to ignore case

## Helpers.String.IsString
### Summary
Determine if the object passed in is a string
### Returns
Whether or not object is a string
### Parameters
* value: Input

## Helpers.String.Lowercase
### Summary
Convert string to lowercase
### Returns
lowercase string
### Parameters
* str: input

## Helpers.String.Occurrences
### Summary
Count number of times a substring appears in base string
### Returns
Number of times string occurred
### Parameters
* str: Base string
* substring: String to match
* ignoreCase: Whether or not to ignore case

## Helpers.String.Prepend
### Summary
Prepend one string to another
### Returns
Prepend string
### Parameters
* str: Base string
* prefix: String to prepend

## Helpers.String.Replace
### Summary
Replace the part of a string with something else.
### Returns
Replaced string
### Parameters
* str: Base string
* a: String to match
* b: Replacement

## Helpers.String.Reverse
### Summary
Reverse a string
### Returns
Reversed string
### Parameters
* str: Input

## Helpers.String.Split
### Summary
Split a string on a supplied delimiter
### Returns
Array of strings
### Parameters
* str: Base string
* ch: Delimiter

## Helpers.String.StartsWith
### Summary
Determine if the string starts with a substring
### Returns
Whether or not the string starts with substring
### Parameters
* str: Base string
* prefix: String to match
* ignoreCase: Whether or not to ignore case

## Helpers.String.Titlecase
### Summary
Convert string to Titlecase
### Returns
Titlecase string
### Parameters
* str: input

## Helpers.String.Trim
### Summary
Trim whitespace from left and right of string
### Returns
Trimmed string
### Parameters
* str: Base string

## Helpers.String.TrimLeft
### Summary
Trim whitespace from left of string
### Returns
Trimmed string
### Parameters
* str: Base string

## Helpers.String.TrimRight
### Summary
Trim whitespace from right of string
### Returns
Trimmed string
### Parameters
* str: Base string

## Helpers.String.Truncate
### Summary
Truncate a long string and append a suffix(if set)
### Returns
Truncated string
### Parameters
* str: String to trucate
* limit: Max number of characters in final string(excluding suffix)
* suffix: Suffix to append if string gets trucated

## Helpers.String.TruncateWords
### Summary
Truncate a long string and base truncation on the number of words instead of characters
### Returns
Truncated string
### Parameters
* str: STring to truncate
* limit: Number of words in final string
* suffix: Suffix to append if string gets truncated

## Helpers.String.Uppercase
### Summary
Convert string to UPPERCASE
### Returns
UPPERCASE string
### Parameters
* str: input

## Helpers.Url.Base64Decode
### Summary
Base64 decode string
### Returns
Decoded string
### Parameters
* str: Base64 string to decode

## Helpers.Url.Base64Encode
### Summary
Base64 encode string
### Returns
Base64 encoded string
### Parameters
* str: String to Baes64 encode

## Helpers.Url.DecodeUri
### Summary
Decode a uri encoded string
### Returns
decoded string
### Parameters
* str: Uri encoded string

## Helpers.Url.EncodeUri
### Summary
Uri encode a string
### Returns
Uri encoded string
### Parameters
* str: String to encode

## Helpers.Url.StripProtocol
### Summary
Remove protocol from url
### Returns
Protocol free url
### Parameters
* str: Url to remove protocol from

