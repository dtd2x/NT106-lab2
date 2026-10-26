using Microsoft.Data.Sqlite;
using NT106_Lab2.Models;

namespace NT106_Lab2.Services
{
    /// <summary>
    /// Bài 06: truy xuất cơ sở dữ liệu SQLite gồm 2 bảng MonAn và NguoiDung.
    /// Mọi câu lệnh đều dùng tham số ($ten...) để tránh lỗi SQL injection.
    /// </summary>
    public class MonAnDatabase
    {
        private const string CotMonAn =
            "m.IDMA, m.TenMonAn, m.HinhAnh, m.IDNCC, n.HoVaTen " +
            "FROM MonAn m JOIN NguoiDung n ON n.IDNCC = m.IDNCC";

        private readonly string chuoiKetNoi;

        public MonAnDatabase(string duongDanFile)
        {
            SqliteConnectionStringBuilder builder = new SqliteConnectionStringBuilder
            {
                DataSource = duongDanFile,
                ForeignKeys = true // bật kiểm tra khoá ngoại IDNCC
            };
            chuoiKetNoi = builder.ToString();
        }

        private SqliteConnection MoKetNoi()
        {
            SqliteConnection ketNoi = new SqliteConnection(chuoiKetNoi);
            ketNoi.Open();
            return ketNoi;
        }

        // Tạo 2 bảng nếu chưa có (file .db tự được tạo ở lần mở đầu tiên)
        public void KhoiTao()
        {
            using SqliteConnection ketNoi = MoKetNoi();
            using SqliteCommand lenh = ketNoi.CreateCommand();
            lenh.CommandText = @"
                CREATE TABLE IF NOT EXISTS NguoiDung (
                    IDNCC    INTEGER PRIMARY KEY AUTOINCREMENT,
                    HoVaTen  TEXT    NOT NULL,
                    QuyenHan TEXT    NOT NULL
                );
                CREATE TABLE IF NOT EXISTS MonAn (
                    IDMA     INTEGER PRIMARY KEY AUTOINCREMENT,
                    TenMonAn TEXT    NOT NULL,
                    HinhAnh  BLOB,
                    IDNCC    INTEGER NOT NULL REFERENCES NguoiDung(IDNCC)
                );";
            lenh.ExecuteNonQuery();
        }

        public bool CoDuLieu()
        {
            using SqliteConnection ketNoi = MoKetNoi();
            using SqliteCommand lenh = ketNoi.CreateCommand();
            lenh.CommandText = "SELECT COUNT(*) FROM NguoiDung";
            return Convert.ToInt64(lenh.ExecuteScalar()) > 0;
        }

        public int ThemNguoiDung(string hoVaTen, string quyenHan)
        {
            using SqliteConnection ketNoi = MoKetNoi();
            using SqliteCommand lenh = ketNoi.CreateCommand();
            lenh.CommandText =
                "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES ($hoVaTen, $quyenHan); " +
                "SELECT last_insert_rowid();";
            lenh.Parameters.AddWithValue("$hoVaTen", hoVaTen);
            lenh.Parameters.AddWithValue("$quyenHan", quyenHan);
            return Convert.ToInt32(lenh.ExecuteScalar());
        }

        public List<NguoiDung> LayDanhSachNguoiDung()
        {
            List<NguoiDung> danhSach = new List<NguoiDung>();
            using SqliteConnection ketNoi = MoKetNoi();
            using SqliteCommand lenh = ketNoi.CreateCommand();
            lenh.CommandText = "SELECT IDNCC, HoVaTen, QuyenHan FROM NguoiDung ORDER BY IDNCC";
            using SqliteDataReader doc = lenh.ExecuteReader();
            while (doc.Read())
            {
                danhSach.Add(new NguoiDung
                {
                    IDNCC = doc.GetInt32(0),
                    HoVaTen = doc.GetString(1),
                    QuyenHan = doc.GetString(2)
                });
            }
            return danhSach;
        }

        public int ThemMonAn(string tenMonAn, byte[]? hinhAnh, int idNguoiDongGop)
        {
            using SqliteConnection ketNoi = MoKetNoi();
            using SqliteCommand lenh = ketNoi.CreateCommand();
            lenh.CommandText =
                "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES ($ten, $hinhAnh, $idncc); " +
                "SELECT last_insert_rowid();";
            lenh.Parameters.AddWithValue("$ten", tenMonAn);
            lenh.Parameters.AddWithValue("$hinhAnh", (object?)hinhAnh ?? DBNull.Value);
            lenh.Parameters.AddWithValue("$idncc", idNguoiDongGop);
            return Convert.ToInt32(lenh.ExecuteScalar());
        }

        public void XoaMonAn(int idma)
        {
            using SqliteConnection ketNoi = MoKetNoi();
            using SqliteCommand lenh = ketNoi.CreateCommand();
            lenh.CommandText = "DELETE FROM MonAn WHERE IDMA = $idma";
            lenh.Parameters.AddWithValue("$idma", idma);
            lenh.ExecuteNonQuery();
        }

        public List<MonAn> LayDanhSachMonAn()
        {
            List<MonAn> danhSach = new List<MonAn>();
            using SqliteConnection ketNoi = MoKetNoi();
            using SqliteCommand lenh = ketNoi.CreateCommand();
            lenh.CommandText = "SELECT " + CotMonAn + " ORDER BY m.IDMA";
            using SqliteDataReader doc = lenh.ExecuteReader();
            while (doc.Read())
            {
                danhSach.Add(DocMonAn(doc));
            }
            return danhSach;
        }

        // Để SQLite chọn ngẫu nhiên bằng ORDER BY RANDOM()
        public MonAn? LayMonAnNgauNhien()
        {
            using SqliteConnection ketNoi = MoKetNoi();
            using SqliteCommand lenh = ketNoi.CreateCommand();
            lenh.CommandText = "SELECT " + CotMonAn + " ORDER BY RANDOM() LIMIT 1";
            using SqliteDataReader doc = lenh.ExecuteReader();
            return doc.Read() ? DocMonAn(doc) : null;
        }

        private static MonAn DocMonAn(SqliteDataReader doc)
        {
            return new MonAn
            {
                IDMA = doc.GetInt32(0),
                TenMonAn = doc.GetString(1),
                HinhAnh = doc.IsDBNull(2) ? null : (byte[])doc.GetValue(2),
                IDNCC = doc.GetInt32(3),
                TenNguoiDongGop = doc.GetString(4)
            };
        }
    }
}
