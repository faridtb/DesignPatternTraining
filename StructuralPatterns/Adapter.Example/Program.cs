

using Adapter.Example;

Plug plug = new();

Televisor tv = new();
Refrigerator refg = new();

Laptop laptop = new();
LowWoltageAdaptor adapter = new(laptop);


plug.Electrify(tv);
plug.Electrify(refg);
plug.Electrify(adapter);
