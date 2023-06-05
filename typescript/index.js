"use strict";
let greet = "hello world!";
greet = "hi";
// string, number, string[], {}, boolean, etc.
let age = 12;
let petNames = ['pancake', 'ellie', 'aurynie'];
// You can specify your return type and parameter type here
function greetPeople(name) {
    return "hello!";
}
greetPeople("ellie!");
let ellie = {
    name: 'Ellie',
    age: 15
};
function greetPets(petToGreet) {
    return `hello ${petToGreet.name}, you are ${petToGreet.age}`;
}
greetPets(ellie);
let people = [
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
let age1 = 4;
let fruit = 'banana';
let hungry = true;
let friends = ['Eren', 'Armin', 'Mikasa', 'Jean', 'Connie', 'Sasha'];
let movie1 = {
    title: 'Jurassic Park',
    year: 1993,
    directors: ['Spielberg'],
    basedOn: 'Jurassic Park by Michael Crichton'
};
let movie2 = {
    title: 'Everything Everywhere All At Once',
    year: 2022,
    directors: ['Kwan', 'Scheinart']
};
let person1 = {
    name: 'Rick Grimes',
    favoriteMovie: {
        title: 'The Shawshank Redemption',
        year: 1994,
        directors: ['Darabont']
    }
};
let movies = [movie1, movie2];
//    I added type annotations to the variables 
let year = "1999";
year = 1999;
let arr = [3];
arr.push('cat');
//  I added type annotations to the variables
let plumber = 'Mario';
plumber = {
    name: 'Mario',
    color: 'red',
    power: 'mushroom'
};
