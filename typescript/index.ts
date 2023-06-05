let greet : string = "hello world!";
greet = "hi";
// string, number, string[], {}, boolean, etc.

let age : number | string = 12;

let petNames : Array<string | number> = ['pancake', 'ellie', 'aurynie'];

// You can specify your return type and parameter type here
function greetPeople(name : string) : string {
    return "hello!";
}

greetPeople("ellie!");

interface Pet {
    name: string,
    age: number,
    dob?: Date | string | number
}

let ellie : Pet = {
    name: 'Ellie',
    age: 15
}

function greetPets(petToGreet : Pet) : string | number {
    return `hello ${petToGreet.name}, you are ${petToGreet.age}`;
}

greetPets(ellie);

/*
For this exercise, create an interface. The interface should have at least 
5 properties and at at least one optional property. Create an array and fill it with at
least 3 objects which fit the interface you created. Be as specific as possible when 
declaring variables (Give all variables a type and don't use the "any" keyword)
*/
// First Exercise create person interface with one optional

interface Person {
    name: string;
    age: number;
    email: string;
    address: string;
    phone: string;
    occupation?: string;
  }

  let people: Person[] = [
    {
      name: "John Doe",
      age: 30,
      email: "john@gmal.com",
      address: "123 Main St",
      phone: "202-123-5444",
      occupation: "Software Engineer"
    },
    {
      name: "Jane Smith",
      age: 25,
      email: "jane@gmail.com",
      address: "456 Park Ave",
      phone: "555-567-4448"
    },
    {
      name: "Bob Johnson",
      age: 35,
      email: "bob@gmail.com",
      address: "789 Elm St",
      phone: "245-909-470",
      occupation: "Teacher"
    }
  ];

//   Exercise 2 Added 2 new interface

  interface Movie {
    title: string;
    year: number;
    directors: string[];
    basedOn?: string;
  }

  interface Person1 {
    name: string;
    favoriteMovie: Movie;
  }

  let age1 = 4;
  let fruit = 'banana';
  let hungry = true;
  
  let friends = ['Eren', 'Armin', 'Mikasa', 'Jean', 'Connie', 'Sasha'];
  
  let movie1 = {
      title: 'Jurassic Park',
      year: 1993,
      directors: ['Spielberg'],
      basedOn: 'Jurassic Park by Michael Crichton'
  }
  
  let movie2 = {
      title: 'Everything Everywhere All At Once',
      year: 2022,
      directors: ['Kwan', 'Scheinart']
  }
  
  let person1 = {
      name: 'Rick Grimes',
      favoriteMovie: {
          title: 'The Shawshank Redemption',
          year: 1994,
          directors: ['Darabont']
      }
  }
  
  let movies = [movie1, movie2]

//    I added type annotations to the variables 
let year: string | number = "1999";
year = 1999;

let arr: (number | string)[] = [3];
arr.push('cat');

//  I added type annotations to the variables
let plumber: string | { name: string; color: string; power: string } = 'Mario';
plumber = {
    name: 'Mario',
    color: 'red',
    power: 'mushroom'
};
