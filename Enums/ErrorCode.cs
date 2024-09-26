using System.ComponentModel;

namespace ESDManagerApi.Enums
{
    public enum ErrorCode
    {
        [Description("Failed")]
        FAILED = -1,
        [Description("Success")]
        SUCCESS = 0,
        [Description("Token Invalid")]
        TOKEN_INVALID = 2,
        [Description("System error")]
        SYSTEM_ERROR = 3,
        [Description("Database failed")]
        DB_FAILED = 4,
        [Description("Thư mục chứa ảnh chưa được cấu hình")]
        FOLDER_IMAGE_NOT_FOUND = 5,
        [Description("Định dạng tập tin không được hỗ trợ")]
        DOES_NOT_SUPPORT_FILE_FORMAT = 6,
        [Description("Not found")]
        NOT_FOUND = 7,
        [Description("Invalid parameters")]
        INVALID_PARAM = 8,
        [Description("Exists")]
        EXISTS = 9,
        [Description("Key cert invalid")]
        INVALID_CERT = 10,
        [Description("Bad request")]
        BAD_REQUEST = 400,
        [Description("Unauthorization")]
        UNAUTHOR = 401,

        [Description("User locked")]
        USER_LOCKED = 20,
        [Description("Otp invalid")]
        OTP_INVALID = 21,
        [Description("Otp expired")]
        OTP_EXPIRED = 22,
        [Description("Tài khoản đã bị khóa. Vui lòng liên hệ Admin để biết thêm chi tiết")]
        ACCOUNT_LOCKED = 23,

        [Description("Mật khẩu không chính xác. Vui lòng thử lại")]
        INVALID_PASS = 24,

        [Description("Tài khoản không tồn tại. Vui lòng kiểm tra lại")]
        ACCOUNT_NOTFOUND = 25,

        [Description("Nhân viên không tồn tại. Vui lòng kiểm tra lại")]
        USER_NOTFOUND = 26,

        [Description("Nhóm không tồn tại. Vui lòng kiểm tra lại")]
        TEAM_NOTFOUND = 27,

        [Description("Thêm nhân viên thất bại")]
        INSERT_FAIL = 28,

        [Description("Code đã tồn tại")]
        CODE_ALREADY_TAKEN = 29,

        [Description("Đã nhập thiếu trường bắt buộc trong excel")]
        EMPTY_REQUIRE_EXCEL =30,

        [Description("Mật khẩu cũ  không chính xác. Vui lòng thử lại")]
        OLD_PASS_WRONG = 31,

        [Description("Sai định dạng ngày")]
        WRONG_FORMAT_DATE = 32,

        [Description("Trong file đã có mã code này")]
        DUPLICATE_CODE = 33,
        [Description("Mã OTP không hợp lệ")]
        INVALID_OTP = 34,
        [Description("Mã OTP đã hết hạn")]
        EXPIRED_OTP = 35,

        [Description("Trong file đã có mã email này")]
        DUPLICATE_EMAIL = 36,

        [Description("Email hoặc Mật khẩu sai ! Vui lòng thử lại")]
        WRONG_LOGIN = 36,
    }
}
