using static StringArrayCreator;
using static StringArrayWorker;

string[] arr = 10.Create()
                  .FillWithRandomStrings(0, 10, 1)
                  .Print();

string[] lessThan = arr.GetValuesLessThanLength(3)
                       .Print();