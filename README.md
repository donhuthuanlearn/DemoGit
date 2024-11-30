# QuanLyThuVien

## Giới thiệu
QuanLyThuVien là một ứng dụng quản lý thư viện, được phát triển bằng .NET Framework và sử dụng cơ sở dữ liệu SQL Server.

---

## 1. Yêu cầu hệ thống
Dự án này được phát triển trên nền tảng **Visual Studio** và sử dụng cơ sở dữ liệu **SQL Server**. Để thiết lập dự án, bạn cần:

### Visual Studio
- **Phiên bản đề xuất**: Visual Studio 2019 hoặc Visual Studio 2022 (Community, Professional hoặc Enterprise đều được).
- **Cài đặt đầy đủ các workload**:
  - **ASP.NET and web development** (nếu là ứng dụng web).
  - **Desktop development with .NET** (nếu là ứng dụng Windows Forms hoặc WPF).

### SQL Server
- **Phiên bản đề xuất**: SQL Server 2019 hoặc SQL Server Express.
- **Công cụ quản lý**: SQL Server Management Studio (SSMS).

### .NET Framework
- Dựa vào mã nguồn, tệp `.sln` sẽ xác định chính xác phiên bản framework được sử dụng. Nhiều khả năng là **.NET Framework 4.5** hoặc cao hơn.

---

## 2. Hướng dẫn cài đặt

### a. Cài đặt Visual Studio
1. Tải Visual Studio từ [trang chính thức](https://visualstudio.microsoft.com/).
2. Trong trình cài đặt, chọn các **Workload** phù hợp:
   - **ASP.NET and web development** (nếu dự án là ứng dụng web).
   - **Desktop development with .NET** (nếu là ứng dụng desktop).

### b. Cài đặt SQL Server
1. Tải **SQL Server** và **SQL Server Management Studio (SSMS)** từ [Microsoft](https://www.microsoft.com/en-us/sql-server/sql-server-downloads).
2. Cài đặt SQL Server với chế độ **Default Instance**.
3. Mở SSMS để kết nối với cơ sở dữ liệu.

### c. Kiểm tra phiên bản .NET Framework
1. Dự án sử dụng tệp `.sln`, kiểm tra tệp `.csproj` hoặc `.config` trong mã nguồn để xác định phiên bản chính xác.
2. Nếu không có tệp đó, Visual Studio sẽ tự động yêu cầu cài đặt phiên bản cần thiết.

---

## 3. Hướng dẫn thiết lập

### a. Tải mã nguồn
1. Tải mã nguồn dự án từ kho lưu trữ hoặc file đã giải nén.
2. Mở tệp `QuanLyThuVien.sln` trong Visual Studio.

### b. Cấu hình cơ sở dữ liệu
1. Mở file `QLTV.sql` trong **SQL Server Management Studio (SSMS)**.
2. Thực thi tệp SQL để khởi tạo cơ sở dữ liệu.
   - Tệp SQL thường chứa thông tin tạo bảng, thêm dữ liệu mẫu.

### c. Cấu hình chuỗi kết nối
1. Mở tệp `app.config` (nếu là ứng dụng desktop) hoặc `web.config` (nếu là ứng dụng web) trong thư mục mã nguồn.
2. Tìm dòng chứa `connectionString` và cập nhật thông tin kết nối đến SQL Server của bạn. Ví dụ:

   ```xml
   <connectionStrings>
       <add name="MyDatabase" 
            connectionString="Server=localhost;Database=QLTV;User Id=sa;Password=your_password;" 
            providerName="System.Data.SqlClient" />
   </connectionStrings>
### d. Chạy ứng dụng
1. Mở dự án trong **Visual Studio**.
2. Nhấn **F5** hoặc chọn **Start** để chạy ứng dụng.
3. Kiểm tra giao diện và các tính năng của ứng dụng để đảm bảo mọi thứ hoạt động đúng.

---

## 4. Ghi chú
- Nếu gặp lỗi thiếu thư viện, sử dụng **NuGet Package Manager** trong Visual Studio để cài đặt các thư viện cần thiết.
- Đảm bảo **SQL Server** đang chạy khi bạn mở ứng dụng.
- Nếu bạn muốn triển khai ứng dụng lên máy khác:
  1. Cài đặt **SQL Server** trên máy đó.
  2. Cập nhật chuỗi kết nối (`connectionString`) trong tệp `app.config` hoặc `web.config` để phù hợp với thông tin của máy mới.
