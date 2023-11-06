public class SeatManager {
    int i;
    bool[] seats;
    public SeatManager(int n) {
        i=0;
        seats = new bool[n];
    }
    
    public int Reserve() {
        while(seats[i])i++;
        seats[i]=true;
        return ++i;
    }
    
    public void Unreserve(int seatNumber) {
        seats[seatNumber-1]=false;
        i=Math.Min(seatNumber-1,i);
    }
}

/**
 * Your SeatManager object will be instantiated and called as such:
 * SeatManager obj = new SeatManager(n);
 * int param_1 = obj.Reserve();
 * obj.Unreserve(seatNumber);
 */