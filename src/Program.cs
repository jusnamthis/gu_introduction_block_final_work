using static StringArrayCreator;
using static StringArrayWorker;

string[] arr = 10.Create()
                  .FillWithRandomStrings()
                  .Print();

string[] lessThan = arr.GetValuesLessThanLength(3)
                       .Print();