using System;
namespace Sealed
{
    public class Seal
    {
        class livingthings
        {

        }
        sealed class Animal : livingthings 
        {

        }
        class Dog:Animal //Not able to Acess the Animal Class 
        {
            
        }
    }
}