string str = Console.ReadLine();
string[] array1 = str.Split(' ');

int IntegerArray(string[] array){
    int index = 0;
    for (int i = 0; i < array.Length; i++){
        if(array[i].Length <= 3){
            index+=i;
            index*=10;
        }
    }
    return index;
}
int GetDigit(int x, int digitNumber){
   int count = x.ToString().Length-1-digitNumber;
   for(int i = 0; i < count; i++){
        x/=10;
   }
   return x%10;
}
void SecondArray(string[] array, int index){
    int count = index.ToString().Length-1;
    string[] array2 = new string[count];
    for(int i = 0; i < count; i++){
        array2[i] = array[GetDigit(index, i)];
        Console.Write(array2[i] + " ");
    }

}

SecondArray(array1, IntegerArray(array1));