object[] array = {"one",2,3};

var result = array.AsEnumerable();

var oftyp = array.OfType<int>();

var cast=array.Cast<int>();

var tohashset = array.ToHashSet();

var toarray = result.ToArray();

var queryable = array.AsQueryable();