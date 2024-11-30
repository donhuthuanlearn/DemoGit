1. Yêu cầu hệ thống
Dự án này được phát triển trên nền tảng Visual Studio và sử dụng cơ sở dữ liệu SQL Server. Để thiết lập dự án, bạn cần:

Visual Studio:
Phiên bản đề xuất: Visual Studio 2019 hoặc Visual Studio 2022 (Community, Professional hoặc Enterprise đều được).
Cài đặt đầy đủ các workload:
ASP.NET and web development (nếu là ứng dụng web).
Desktop development with .NET (nếu là ứng dụng Windows Forms hoặc WPF).
SQL Server:
Phiên bản đề xuất: SQL Server 2019 hoặc SQL Server Express.
Công cụ quản lý: SQL Server Management Studio (SSMS).
.NET Framework:
Dựa vào mã nguồn, tệp .sln sẽ xác định chính xác phiên bản framework được sử dụng. Nhiều khả năng là .NET Framework 4.5 hoặc cao hơn.
2. Hướng dẫn cài đặt
a. Cài đặt Visual Studio
Tải Visual Studio từ trang chính thức.
Trong trình cài đặt, chọn các Workload phù hợp:
ASP.NET and web development (nếu dự án là ứng dụng web).
Desktop development with .NET (nếu là ứng dụng desktop).
b. Cài đặt SQL Server
Tải SQL Server và SQL Server Management Studio (SSMS) từ Microsoft.
Cài đặt SQL Server với chế độ Default Instance.
Mở SSMS để kết nối với cơ sở dữ liệu.
c. Kiểm tra phiên bản .NET Framework
Dự án sử dụng .sln, kiểm tra tệp .csproj hoặc .config trong mã nguồn để xác định phiên bản chính xác. Nếu không có tệp đó, Visual Studio sẽ tự động yêu cầu cài đặt phiên bản cần thiết.
3. Hướng dẫn thiết lập
a. Tải mã nguồn
Tải mã nguồn dự án từ kho lưu trữ hoặc file đã giải nén.
Mở tệp QuanLyThuVien.sln trong Visual Studio.
b. Cấu hình cơ sở dữ liệu
Mở file QLTV.sql trong SQL Server Management Studio (SSMS).
Thực thi tệp SQL để khởi tạo cơ sở dữ liệu.
Lệnh SQL thường sẽ chứa thông tin tạo bảng, thêm dữ liệu mẫu.
c. Cấu hình chuỗi kết nối
Mở tệp app.config (nếu là ứng dụng desktop) hoặc web.config (nếu là ứng dụng web) trong thư mục mã nguồn.

Tìm dòng chứa connectionString và cập nhật thông tin kết nối đến SQL Server của bạn. Ví dụ:

xml
Sao chép mã
<connectionStrings>
    <add name="MyDatabase" 
         connectionString="Server=localhost;Database=QLTV;User Id=sa;Password=your_password;" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
d. Chạy ứng dụng
Trong Visual Studio, nhấn F5 hoặc chọn Start để chạy ứng dụng.
Kiểm tra giao diện và tính năng của ứng dụng.
4. Ghi chú
Nếu gặp lỗi thiếu thư viện, sử dụng NuGet Package Manager trong Visual Studio để cài đặt các thư viện cần thiết.
Đảm bảo SQL Server đang chạy khi bạn mở ứng dụng.
Nếu bạn muốn triển khai ứng dụng lên máy khác, đảm bảo cài đặt SQL Server và thay đổi chuỗi kết nối tương ứng.
