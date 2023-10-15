public class Solution {
    public void traverse(int[][] graph, List<List<int>> result, List<int> route){
        // base case
        if(route[route.Count-1]==graph.Length-1){
            result.Add(new List<int>(route));
            return;
        }
        int i = route[route.Count-1];
        foreach(int nextNode in graph[i]){
            route.Add(nextNode);
            traverse(graph,result,route);
            route.RemoveAt(route.Count-1);
        }
    }
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        // NOTES: 
        // last node is graph.Length-1
        // we start by grapgh [i] and foreach one of them we recurse
        List<List<int>> result = new List<List<int>>();
        List<int> route = new List<int> {0};
        traverse(graph, result, route);
        IList<IList<int>> resultList = new List<IList<int>>(result);
        return resultList;
    }
}