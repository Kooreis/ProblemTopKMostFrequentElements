Here is a Python console application that solves the problem:

```python
from collections import Counter

def top_k_frequent(nums, k):
    count = Counter(nums)
    return [num for num, _ in count.most_common(k)]

def main():
    nums = input("Enter numbers separated by space: ").split()
    k = int(input("Enter value of K: "))
    nums = [int(num) for num in nums]
    print(top_k_frequent(nums, k))

if __name__ == "__main__":
    main()
```

This application first asks the user to input a list of numbers separated by spaces. It then asks for the value of K. It converts the input string into a list of integers and then calls the `top_k_frequent` function, which uses the `Counter` class from the `collections` module to count the frequency of each number in the list. The `most_common(k)` method of the `Counter` object returns the K most common elements in the list. The function then returns a list of just the numbers from these elements. The application then prints this list.