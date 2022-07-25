// let data: any = 42;
// let data: number | string = 42;
//let data = 42

// Creating the Duck interface and making it accessible (public)
export interface Duck {
    name: string;
    numLegs: number;
    makeSound: (sound: string) => void;
}

// Definding duck1
const duck1:Duck = {
    name: 'huey',
    numLegs: 2,
    makeSound: (sound: any) => console.log(sound)
}

// Defining duck2
const duck2:Duck = {
    name: 'dewey',
    numLegs: 2,
    makeSound: (sound: any) => console.log(sound)
}

// Invoking the makeSound() method
duck1.makeSound('quack');

// Creating an array of duck objects
export const ducks = [duck1, duck2];