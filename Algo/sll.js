// Node class 
// MY try 

// class Node{
//     constructor(First, Second) {
//         class First{
//             constructor(value,key){
//                 this.value= value
//                 this.key= key

//             }
//         class Second{
//             constructor(valuesec , keysec){
//                 this.valuesec = valuesec
//                 thi.keysec = keysec
//             }
//         }
//         }
//     }
    
// }



class Node{
    constructor(value){
        this.value = value
        this.next = null
    }
}

class SLL{
    constructor(){
        this.head = null
    }
    isEmpty(){
        if (this.head == null){
            return true
        }else{
            return false
        }
    }
    addToFront(value){
        let newNode = new Node(value);
        if(this.isEmpty() == true){
            this.head = newNode;
            return this
        }else{
            newNode.next = this.head;
            this.head = newNode;
            return this;
        }
    }
    print()
    {
        if(this.isEmpty()){
            false
        }else{
        // print the values of all the nodes 
        let runner = this.head;
        while(runner){
            console.log(runner.value);
            runner = runner.next;
        }
        }
    }
    addToBack()
    {
    let newNode = new Node(value);
    if(this.isEmpty()){
        this.head = newNode;
    }else{
        //search for the last node and add the new node
        let runner = this.head;
        while(runner.next){
            runner = runner.next
        }
        runner.next = newNode;
    }
    }
    length(){
        if(this.isEmpty()){
            return 0
        }else{
            let count = 1;
            let runner = this.head;
            while(runner.next){
                count ++ 
                runner = runner.next
            }
            return count
        }
    }
}

let nodeOne = new Node(10);
let nodeTwo = new Node(-2)
const sll = new SLL()
const sllTwo = new SLL()
nodeOne.next = nodeTwo
sll.head = nodeOne
let nodeThree = new Node (7)



console.log("SLL before",sll);
console.log("SLL Two Before",sllTwo);
sll.addToFront(7)
sllTwo.addToFront(7)

console.log("SLL After",sll);
console.log("SLL Two After",sllTwo);

// console.log(nodeOne);
// console.log("First SLL EMPTY ? =>",sll.isEmpty());
// console.log("Second SLL EMPTY ? =>",sllTwo.isEmpty());
// console.log(nodeTwo);




