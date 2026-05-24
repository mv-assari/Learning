IList<State> states = new List<State>()
{
    new State{Id=1,Name="کردستان"},
    new State{Id=2,Name="مازندران"},
};

IList<City> citys = new List<City>
{
    new City{Id=1,Name="سنندج",stateId=1},
    new City{Id=2,Name="مریوان",stateId=1},
    new City{Id=3,Name="بانه",stateId=1},
    new City{Id=4,Name="بابلسر",stateId=2},
    new City{Id=5,Name="رامسر",stateId=2},
};

var result = citys.Join(states, c => c.stateId, s => s.Id, (city, state) => new
{
    CityId=city.Id,
    CityName=city.Name,
    StateName=state.Name,
});



//-------------------------------

public class State
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int stateId {  get; set; }
}