def turnip(arr):
    stack = []
    res = [0] * len(arr)
    for i in range(len(arr)):
        while stack and arr[stack[-1]] < arr[i]:
            res[stack.pop()] = i - stack[-1]
        stack.append(i)
    return res
