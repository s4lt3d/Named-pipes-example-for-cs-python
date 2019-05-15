import win32file
serverFileHandle = win32file.CreateFile("\\\\.\\pipe\\Server", win32file.GENERIC_READ | win32file.GENERIC_WRITE, 0, None, win32file.OPEN_EXISTING, 0, None)
_, data_to_read = win32file.ReadFile(serverFileHandle, 4096)
print(data_to_read) # prints "Hello Python"

win32file.WriteFile(serverFileHandle,"Hello Back\r\n".encode(),None)

