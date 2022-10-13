Arrays a = new Arrays();
string [] array = {"Hello","2","World",":-)"};
//string[] array = { "RUSSIA", "DENMARK", "KAZAN" };

a.PrintArray(array);

int count = 0;
for (int i = 0; i < array.GetLength(0); i++)

    if (array[i].Length <= 3) count++;

string[] newArray = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
        newArray[j++] = array[i];

Console.Write("-> ");

if (newArray.GetLength(0) > 0)
    a.PrintArray(newArray);
else
    Console.Write("[]");
