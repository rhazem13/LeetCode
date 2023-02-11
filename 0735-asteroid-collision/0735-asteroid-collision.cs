public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack=new();
        for(int i=0;i<asteroids.Length;i++){
            int cur = asteroids[i];
            if(stack.Count==0)
                stack.Push(cur);
            else{
                while(stack.Count>0){
                    if((stack.Peek()>0 && cur<0)){
                        if(Math.Abs(cur)>Math.Abs(stack.Peek())){
                            stack.Pop();
                            if(stack.Count==0){
                                stack.Push(cur);
                                break;
                            }
                        }
                        else if(Math.Abs(cur)==Math.Abs(stack.Peek())){
                            stack.Pop();
                            break;
                        }
                        else{
                            break;
                        }
                    }
                    else{
                        stack.Push(cur);
                        break;
                    }
                }
            }
        }
        var result= stack.ToArray();
        Array.Reverse(result);
        return result;
    }
}