using System;

namespace ParameterTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value type example
            int valueTypeVar = 10;
            Console.WriteLine("Before calling ModifyValueType: " + valueTypeVar);
            ModifyValueType(valueTypeVar);
            Console.WriteLine("After calling ModifyValueType: " + valueTypeVar);

            // Reference type example
            int[] referenceTypeArray = { 1, 2, 3 };
            Console.WriteLine("Before calling ModifyReferenceType: " + string.Join(", ", referenceTypeArray));
            ModifyReferenceType(referenceTypeArray);
            Console.WriteLine("After calling ModifyReferenceType: " + string.Join(", ", referenceTypeArray));
        }

        static void ModifyValueType(int value)
        {
            value = 20;
            Console.WriteLine("Inside ModifyValueType: " + value);
        }

        static void ModifyReferenceType(int[] array)
        {
            array[0] = 99;
            Console.WriteLine("Inside ModifyReferenceType: " + string.Join(", ", array));
        }
    }
}
