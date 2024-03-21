using System;

string[] array = new string[4];
array[0]="Hello";
array[1]="2";
array[2]="World";
array[3]=":-)";
int len = array.Length-1;
int i = 0;
int count = 0;
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