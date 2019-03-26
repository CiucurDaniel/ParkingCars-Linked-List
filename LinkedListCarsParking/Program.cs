using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCarsParking
{
    /* CIUCUR DANIEL   Uvt Informatica - engleza an 1
     * 
     * ADS 2 Homework 1 Problem 2  Parking Cars */
    public class LinkedList
    {
        
        public class Node
        {
            public string car;
            public Node next;
            public Node(string d)
            {
                car = d; next = null;
            } // Constructor 
        }

        Node head; // head of list 
        Node tail; // tail of list


        public void enterTheParking(string licensePlate)
        {

            Node newCar = new Node(licensePlate);
            newCar.car = licensePlate;
            newCar.next = null;

            if (head == null)
            {
                head = newCar;
                tail = newCar;
            }
            else
            {
                tail.next = newCar;
                tail = tail.next;
            }

        }
        public void showCars()
        {
            Node n = head;
            if (head == null) Console.WriteLine("The parking is empty.");
            while (n != null)
            {
                Console.WriteLine(n.car + " ");
                n = n.next;
            }
        }
   
        public void exitTheParking()
        {
            if(head == null)
            {
                Console.WriteLine("There are no cars in the parking spot.");
            }
            else
            {
                string auxCar = head.car;

                if(head.next == null)
                {
                    auxCar = head.car;
                    head = null;
                }
                else
                {
                    Node car1, car2;
                    car2 = head;
                    car1 = head.next;

                    while(car1.next != null)
                    {
                        car2 = car1;
                        car1 = car1.next;
                    }

                    auxCar = car1.car;
                    car2.next = null;
                }
            }
        }

        public static void Main(String[] args)
        {
            LinkedList parkingSpot = new LinkedList();
            bool ok=true;

            while(ok)
            {
                string input;
                string license;

                Console.WriteLine("What do you want to do ? \nPress --1-- to end program, \n--2-- to enter a car " +
                    "\n--3-- to exit a car from the parking \n--4-- to show cars");
                input = Console.ReadLine();

                if(input == "1")
                {
                    Console.WriteLine("Program ended!");
                    ok = false;
                }

                else if(input == "2")
                {
                    Console.WriteLine("Enter the license plate of the car you want to enter: ");
                    license = Console.ReadLine();
                    parkingSpot.enterTheParking(license);
                }

                else if(input == "3")
                {
                    Console.WriteLine("Cars before: ");
                    parkingSpot.showCars();
                    Console.WriteLine();
                    Console.WriteLine("Cars after: ");
                    parkingSpot.exitTheParking();
                    parkingSpot.showCars();

                }

                else if(input == "4")
                {
                    Console.WriteLine("The cars in parking spot are: ");
                    parkingSpot.showCars();
                }
                else
                {
                    Console.WriteLine("Unrecognized command! \n");
                }
            }
        }
    }
}
