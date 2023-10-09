class Node {
    constructor(value){
        this.value = value;
        this.left = null; 
        this.right = null;
    }
}

class BinarySearchTree{
    constructor(){
        this.root = null 
    }
    isEmpty(){
        if (this.root == null){
            return true
        }else{
            return false
        }
    }


    min(){
        if(this.isEmpty()){
            return false
        }else{
            let runner = this.root ;
            let min =this.root.value;
            while(runner.left){
                min = runner.left.value;
                runner = runner.right;
            }
            return min
            
        }
    }
    max(){
        if(this.isEmpty()){
            return false
        }else{
            let runner = this.root ;
            let max =this.root.value;
            while(runner.right){
                max = runner.right.value;
                runner = runner.left;
                
            }
            return max
            
        }
    }

}

let nodeOne = new Node(10);

let nodeTwo = new Node(-2)
let nodeThree = new Node(7)
let nodeFour = new Node(20)
let nodeFive = new Node(-5)
nodeOne.left = nodeTwo;
nodeTwo.right = nodeThree;
nodeOne.right = nodeFour;
nodeTwo.left =nodeFive;


const bst = new BinarySearchTree()

bst.root = nodeOne;
console.log(bst.min());