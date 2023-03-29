```java
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Integer[] nums = {1,1,1,2,2,3,3,3,3,4,4,4,5,5,5,5,5};
        int k = 2;
        List<Integer> topKFrequent = topKFrequent(nums, k);
        System.out.println(topKFrequent);
    }

    public static List<Integer> topKFrequent(Integer[] nums, int k) {
        Map<Integer, Integer> count = new HashMap<>();
        for (int num : nums) {
            count.put(num, count.getOrDefault(num, 0) + 1);
        }

        PriorityQueue<Integer> heap = new PriorityQueue<>(Comparator.comparingInt(count::get));
        for (int num : count.keySet()) {
            heap.add(num);
            if (heap.size() > k) heap.poll();
        }

        List<Integer> top_k = new LinkedList<>();
        while (!heap.isEmpty()) top_k.add(heap.poll());
        Collections.reverse(top_k);
        return top_k;
    }
}
```