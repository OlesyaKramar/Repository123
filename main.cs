while(i<len){
    if (array[i].Length<=3){
        count++;
        i++;
    }
    else{
        i++;
    }
}
i=0;
count=0;
string[] new_array = new string[count+1];
while(i<len){
    if (array[i].Length<=3){
        new_array[count]=array[i];
        count++;
        i++;
    }
    else{
        i++;
    }
}
Console.WriteLine(new_array);