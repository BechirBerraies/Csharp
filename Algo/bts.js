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
    insert(value){
        let newNode = new Node(value)
        if(this.isEmpty()){
            this.root = newNode;
            return this;
        }else
        {
            let runner = this.root
            while(runner){
                if(runner.value> value){
                    if(runner.left){
                        runner = runner.left
                    }else{
                        runner.left = newNode
                        return this
                    }
                }else{
                    if(runner.right){
                        runner = runner.right
                    }else{
                        runner.right= newNode
                        return this
                    }
                }
            }
        }
    }
    find(value){
        if(this.isEmpty() ){
            return false
        }
        else{
            let runner = this.root
            while(runner){
                if (runner.value ==  value){
                    return true;
                }
                else {
                    if(runner.value > value){
                        runner = runner.left
                    }else{
                        runner = runner.right;
                    }
                }
            }
            return false
        }
        
    }
    removeMinValue(){
        if(this.isEmpty()){
            return false
        }
        else{
            let runner = this.root
            if(runner.left == null)
            {
            this.root = runner.right
            return this;
            }else{
                while(runner.left){
                    if(runner.left.left == null)
                    {
                        runner.left = null
                        return this
                    }else{
                        runner = runner.left
                    }
                }
                return this
            }
        }
    }
    removeMaxValue(){
        if(this.isEmpty()){
            return false
        }
        else{
            let runner = this.root
            if(runner.right == null)
            {
            this.root = runner.left
            return this;
            }else{
                while(runner.right){
                    if(runner.right.right == null)
                    {
                        runner.right = null
                        return this
                    }else{
                        runner = runner.right
                    }
                }
                return this
            }
        }
    }

}

// let nodeOne = new Node(10);

// let nodeTwo = new Node(-2)
// let nodeThree = new Node(7)
// let nodeFour = new Node(20)
// let nodeFive = new Node(-5)
// nodeOne.left = nodeTwo;
// nodeTwo.right = nodeThree;
// nodeOne.right = nodeFour;
// nodeTwo.left =nodeFive;





const bst = new BinarySearchTree()
// console.log("1 - ",bst);
bst.insert(10)
// console.log("2 - ",bst);
bst.insert(-2)
// console.log("3 - ",bst);
bst.insert(7)
// console.log("4 - ",bst);
bst.insert(20)
// console.log("5 - ",bst);
// bst.find(7);
// console.log("5 - ",bst);
console.log("6 - ",bst);


console.log("Find 20 in BST :", bst.find(3));


console.log("Remove last :" ,bst.removeMaxValue());

console.log(bst);

// bst.root = nodeOne;
// console.log(bst.min());