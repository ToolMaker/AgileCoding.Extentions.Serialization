AgileCoding.Extensions.Serialization
====================================

Overview
--------

AgileCoding.Extensions.Serialization is a .NET library that provides extension methods to enhance serialization behavior. It is built for .NET 6.0 and leverages the popular Newtonsoft.Json library to allow for flexible and powerful serialization and deserialization.

Installation
------------

This library is distributed via NuGet. To install it, use the NuGet package manager console:

bash

`Install-Package AgileCoding.Extensions.Serialization -Version 2.0.5`

Features
--------

This library introduces two extension methods, `JSONSerialization` and `JSONDeserialize`.

`JSONSerialization` is an extension method for serializing objects to JSON.

`JSONDeserialize` is an extension method for deserializing JSON strings into objects.

Usage
-----

Here's an example of how to use these methods in your code:

```csharp
using AgileCoding.Extentions.Serialization;
using Newtonsoft.Json;

// Create an object
var myObject = new MyObject();

// Serialize the object to a JSON string
string json = myObject.JSONSerialization(TypeNameHandling.All);

// Deserialize the JSON string back into an object
MyObject deserializedObject = json.JSONDeserialize<MyObject>(TypeNameHandling.All);
```

Documentation
-------------

For more detailed information about the usage of this library, please refer to the [official documentation](https://github.com/ToolMaker/AgileCoding.Extentions.Serialization/wiki).

License
-------

This project is licensed under the terms of the MIT license. For more information, see the [LICENSE](https://github.com/ToolMaker/AgileCoding.Extentions.Serialization/blob/main/LICENSE) file.

Contributing
------------

Contributions are welcome! Please see our [contributing guidelines](https://github.com/ToolMaker/AgileCoding.Extentions.Serialization/blob/main/CONTRIBUTING.md) for more details.