/*
========================================
CÂU 1
Phân biệt Value Type và Reference Type
========================================

Value Type (Kiểu giá trị):
- Lưu trực tiếp giá trị trong vùng nhớ Stack.
- Khi gán biến cho nhau sẽ sao chép dữ liệu.
- Các kiểu phổ biến:
  int, double, float, bool, char, struct, enum.

Ví dụ:

int a = 10;
int b = a;
b = 20;

// a = 10
// b = 20

----------------------------------------

Reference Type (Kiểu tham chiếu):
- Đối tượng được lưu trên Heap.
- Biến chỉ lưu địa chỉ tham chiếu tới đối tượng.
- Khi gán biến cho nhau sẽ sao chép địa chỉ.

Ví dụ:

Student s1 = new Student();
Student s2 = s1;

s2.Name = "An";

// s1.Name cũng thay đổi thành "An"

========================================
CÂU 2
Init-only Property (init)
========================================

set:
- Có thể thay đổi giá trị bất kỳ lúc nào.

Ví dụ:

public string Name { get; set; }

Student s = new Student();
s.Name = "Nam";
s.Name = "An";

----------------------------------------

init:
- Chỉ được gán khi khởi tạo đối tượng.
- Sau khi tạo xong không thể thay đổi.

Ví dụ:

public string Name { get; init; }

Student s = new Student
{
    Name = "Nam"
};

// s.Name = "An"; // Lỗi

----------------------------------------

Ứng dụng thực tế:
- Mã sinh viên.
- Mã sản phẩm.
- CCCD.
- Thông tin cấu hình chỉ đọc.

========================================
CÂU 3
Virtual và Override
========================================

virtual:
- Khai báo ở lớp cha.
- Cho phép lớp con ghi đè.

Ví dụ:

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal");
    }
}

----------------------------------------

override:
- Khai báo ở lớp con.
- Thay thế cách cài đặt của lớp cha.

Ví dụ:

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof");
    }
}

----------------------------------------

Đa hình:

Animal a = new Dog();
a.Speak();

Kết quả:

Woof

========================================
CÂU 4
Vì sao static không truy xuất qua object?
========================================

Thành phần static thuộc về Class,
không thuộc về từng đối tượng.

Ví dụ:

class Student
{
    public static string School = "FPT";
}

Truy cập:

Console.WriteLine(Student.School);

Không cần:

Student s = new Student();

vì biến School không nằm trong đối tượng s.

----------------------------------------

Lợi ích:
- Dùng chung dữ liệu.
- Tiết kiệm bộ nhớ.
- Hỗ trợ các Utility Method.

Ví dụ:

Math.Sqrt(25);

Sqrt() là phương thức static.
*/
