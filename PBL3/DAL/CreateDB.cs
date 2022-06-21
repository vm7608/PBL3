using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
namespace PBL3.DAL
{
    public class CreateDB :
    // CreateDatabaseIfNotExists<MyData>
    //DropCreateDatabaseIfModelChanges<MyData>
    DropCreateDatabaseAlways<MyData>
    {
        protected override void Seed(MyData context)
        {
            context.Roles.AddRange(new Role[]
            {
                new Role {RoleID = 1, RoleName = "Admin"},
                new Role {RoleID = 2, RoleName = "Host"},
                new Role {RoleID = 3, RoleName = "Renter"}
            });

            context.Accounts.AddRange(new Account[]
            {
                new Account {AccountID = 1, Username = "Admin1", Password = "0000", RoleID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Account {AccountID = 2, Username = "Host1", Password = "0000", RoleID = 2, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Account {AccountID = 3, Username = "Renter1", Password = "0000", RoleID = 3, CreatedAt = DateTime.Now, ModifiedAt = null},
            });
            context.Districts.AddRange(new District[]
            {
                new District {DistrictID = 1, DistrictName = "Quận Hải Châu", CreatedAt = DateTime.Now, ModifiedAt = null},
                new District {DistrictID = 2, DistrictName = "Quận Cẩm Lệ", CreatedAt = DateTime.Now, ModifiedAt = null},
                new District {DistrictID = 3, DistrictName = "Quận Thanh Khê", CreatedAt = DateTime.Now, ModifiedAt = null},
                new District {DistrictID = 4, DistrictName = "Quận Liên Chiểu", CreatedAt = DateTime.Now, ModifiedAt = null},
                new District {DistrictID = 5, DistrictName = "Quận Ngũ Hành Sơn", CreatedAt = DateTime.Now, ModifiedAt = null},
                new District {DistrictID = 6, DistrictName = "Quận Sơn Trà", CreatedAt = DateTime.Now, ModifiedAt = null},
                new District {DistrictID = 7, DistrictName = "Huyện Hòa Vang", CreatedAt = DateTime.Now, ModifiedAt = null},
                //new District {DistrictID = 8, DistrictName = "Trường Sa", CreatedAt = DateTime.Now, ModifiedAt = null},
            });
            context.Wards.AddRange(new Ward[]
            {
                //huyện hòa vang
                new Ward {WardID = 1, WardName = "Xã Hòa Phong", DistrictID = 7, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 2, WardName = "Xã Hòa Bắc", DistrictID = 7, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 3, WardName = "Xã Hòa Châu", DistrictID = 7, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 4, WardName = "Xã Hòa Khương", DistrictID = 7, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 5, WardName = "Xã Hòa Liên", DistrictID = 7, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 6, WardName = "Xã Hòa Nhơn", DistrictID = 7, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 7, WardName = "Xã Hòa Ninh", DistrictID = 7, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 8, WardName = "Xã Hòa Phú", DistrictID = 7, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 9, WardName = "Xã Hòa Phước", DistrictID = 7, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 10, WardName = "Xã Hòa Sơn", DistrictID = 7, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 11, WardName = "Xã Hòa Tiến", DistrictID = 7, CreatedAt = DateTime.Now, ModifiedAt = null},
                //quận hải châu
                new Ward {WardID = 12, WardName = "Phường Bình Hiên", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 13, WardName = "Phường Bình Thuận", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 14, WardName = "Phường Hải Châu I", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 15, WardName = "Phường Hòa Châu II", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 16, WardName = "Phường Hòa Cường Bắc", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 17, WardName = "Phường Hòa Cường Nam", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 18, WardName = "Phường Hòa Thuận Đồng", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 19, WardName = "Phường Hòa Thuận Tây", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 20, WardName = "Phường Nam Dương", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 21, WardName = "Phường Phước Ninh", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 22, WardName = "Phường Thạch Thang", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 23, WardName = "Phường Thanh Bình", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 24, WardName = "Phường Thuận Phước", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                //quận cẩm lệ
                new Ward {WardID = 25, WardName = "Phường Hòa An", DistrictID = 2, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 26, WardName = "Phường Hòa Phát", DistrictID = 2, CreatedAt = DateTime.Now, ModifiedAt = null},//
                new Ward {WardID = 27, WardName = "Phường Hòa Thọ Đông", DistrictID = 2, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 28, WardName = "Phường Hòa Thọ Tây", DistrictID = 2, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 29, WardName = "Phường Hòa Xuân", DistrictID = 2, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 30, WardName = "Phường Khuê Trung", DistrictID = 2, CreatedAt = DateTime.Now, ModifiedAt = null},
                 //quận thanh khê dis id = 3
                new Ward {WardID = 31, WardName = "Phường An Khê", DistrictID = 3, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 32, WardName = "Phường Chính Gián", DistrictID = 3, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 33, WardName = "Phường Hòa Khê", DistrictID = 3, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 34, WardName = "Phường Tam Thuận", DistrictID = 3, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 35, WardName = "Phường Tân Chính", DistrictID = 3, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 36, WardName = "Phường Thạc Gián", DistrictID = 3, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 37, WardName = "Phường Thanh Khê Đông", DistrictID = 3, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 38, WardName = "Phường Thanh Khê Tây", DistrictID = 3, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 39, WardName = "Phường Vĩnh Trung", DistrictID = 3, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 40, WardName = "Phường Xuân Hà", DistrictID = 3, CreatedAt = DateTime.Now, ModifiedAt = null},
                //quận liên chiểu dis id = 4
                new Ward {WardID = 41, WardName = "Phường Hòa Hiệp Bắc", DistrictID = 4, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 42, WardName = "Phường Hòa Hiệp Nam", DistrictID = 4, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 43, WardName = "Phường Hòa Khánh Bắc", DistrictID = 4, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 44, WardName = "Phường Hòa Khánh Nam", DistrictID = 4, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 45, WardName = "Phường Hòa Minh", DistrictID = 4, CreatedAt = DateTime.Now, ModifiedAt = null},       
                //quận ngũ hành sơn dis = 5
                new Ward {WardID = 46, WardName = "Phường Hòa Hải", DistrictID = 5, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 47, WardName = "Phường Hòa Quý", DistrictID = 5, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 48, WardName = "Phường Khuê Mỹ", DistrictID = 5, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 49, WardName = "Phường Mỹ An", DistrictID = 5, CreatedAt = DateTime.Now, ModifiedAt = null},
                //quận sơn trà dis id = 6
                new Ward {WardID = 50, WardName = "Phường An Hải Bắc", DistrictID = 6, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 51, WardName = "Phường An Hải Đông", DistrictID = 6, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 52, WardName = "Phường An Hải Tây", DistrictID = 6, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 53, WardName = "Phường Mân Thái", DistrictID = 6, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 54, WardName = "Phường Nại Hiên Đông", DistrictID = 6, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 55, WardName = "Phường Phước Mỹ", DistrictID = 6, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 56, WardName = "Phường Thọ Quang", DistrictID = 6, CreatedAt = DateTime.Now, ModifiedAt = null},
            });
            //13 trường đại học tất cả
            context.Universities.AddRange(new University[]
            {
                new University {UniversityID = 1, UniversityName = "ĐH Bách Khoa Đà Nẵng", WardID = 43, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 2, UniversityName = "ĐH CNTT & TT Việt Hàn", WardID = 46, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 3, UniversityName = "ĐH Kinh Tế Đà Nẵng", WardID = 49, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 4, UniversityName = "ĐH Kỹ thuật Y dược Đà Nẵng", WardID = 14, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 5, UniversityName = "ĐH Ngoại Ngữ Đà Nẵng", WardID = 30, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 6, UniversityName = "ĐH Sư Phạm Đà Nẵng", WardID = 44, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 7, UniversityName = "ĐH Sư Phạm Kỹ thuật Đà Nẵng", WardID = 23, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 8, UniversityName = "ĐH Thể dục Thể thao Đà Nẵng", WardID = 38, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 9, UniversityName = "Khoa CNTT & TT ĐH Đà Nẵng", WardID = 46, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 10, UniversityName = "Khoa Y dược - ĐH Đà Nẵng", WardID = 47, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 11, UniversityName = "ĐH Duy Tân", WardID = 36, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 12, UniversityName = "ĐH Đông Á", WardID = 17, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 13, UniversityName = "ĐH Kiến Trúc Đà Nẵng", WardID = 17, CreatedAt = DateTime.Now, ModifiedAt = null},
            });
            context.Addresses.AddRange(new Address[]
            {
                new Address {AddressID = 1, WardID = 43, DetailAddress = "54 Nguyễn Lương Bằng"},
                new Address {AddressID = 2, WardID = 49, DetailAddress = "71 Ngũ Hành Sơn"},
                new Address {AddressID = 3, WardID = 10, DetailAddress = "459 Tôn Đức Thắng"},
                new Address {AddressID = 4, WardID = 7, DetailAddress = "xxx"},
                new Address {AddressID = 5, WardID = 2, DetailAddress = "yyy"},
                new Address {AddressID = 6, WardID = 13, DetailAddress = "zzz"},
                new Address {AddressID = 7, WardID = 25, DetailAddress = "aaa"},
                new Address {AddressID = 8, WardID = 33, DetailAddress = "bbb"},
                new Address {AddressID = 9, WardID = 34, DetailAddress = "ccc"},
                new Address {AddressID = 10, WardID = 50, DetailAddress = "ddd"},


            });
            context.Users.AddRange(new User[]
            {
                new User {UserID = 1, FullName = "CKVM", Email ="1@gmail.com", AddressID = 5, Phone = "123", AccountID = 1},
                new User {UserID = 2, FullName = "LNNL", Email ="2@gmail.com", AddressID = 4, Phone = "456", AccountID = 2},
                new User {UserID = 3, FullName = "VHB", Email ="3@gmail.com", AddressID = 1, Phone = "789", AccountID = 3},
            });
            context.Posts.AddRange(new Post[]
            {
                new Post {PostID = 1, UserID = 2, AddressID = 3, Title = "Cho thuê trọ tại BK ĐN", Description = "Trọ bao đẹp",
                            Price = 1300000, Area = 22.5, BeingPosted = true, BeingRented = false,
                            CreatedAt = DateTime.Now, PublishedAt = DateTime.Now, ModifiedAt = null
                },
                new Post {PostID = 2, UserID = 2, AddressID = 2, Title = "Cho thuê trọ tại ĐH KT ĐN", Description = "Trọ bao đẹp",
                            Price = 1000000, Area = 15, BeingPosted = false, BeingRented = false,
                            CreatedAt = DateTime.Now, PublishedAt = null, ModifiedAt = null
                },
                new Post {PostID = 3, UserID = 2, AddressID = 6, Title = "Cho thuê trọ tại ĐH SP DN", Description = "Trọ bao đẹp",
                            Price = 10320000, Area = 23, BeingPosted = true, BeingRented = false,
                            CreatedAt = DateTime.Now, PublishedAt = DateTime.Now, ModifiedAt = null
                },
                new Post {PostID = 4, UserID = 2, AddressID = 7, Title = "Post4", Description = "Trọ bao đẹp",
                            Price = 1200000, Area = 25, BeingPosted = true, BeingRented = false,
                            CreatedAt = DateTime.Now, PublishedAt = DateTime.Now, ModifiedAt = null
                },
                new Post {PostID = 5, UserID = 2, AddressID = 8, Title = "Post5", Description = "Trọ bao đẹp",
                            Price = 1700000, Area = 17.5, BeingPosted = true, BeingRented = false,
                            CreatedAt = DateTime.Now, PublishedAt = DateTime.Now, ModifiedAt = null
                },
                new Post {PostID = 6, UserID = 2, AddressID = 9, Title = "Post6", Description = "Trọ bao đẹp",
                            Price = 1320000, Area = 15.5, BeingPosted = true, BeingRented = false,
                            CreatedAt = DateTime.Now, PublishedAt = DateTime.Now, ModifiedAt = null
                },
                new Post {PostID = 7, UserID = 2, AddressID = 10, Title = "Post7", Description = "Trọ bao đẹp",
                            Price = 820000, Area = 10.5, BeingPosted = true, BeingRented = false,
                            CreatedAt = DateTime.Now, PublishedAt = DateTime.Now, ModifiedAt = null
                }
            });

            context.Images.AddRange(new Image[]
            {
                new Image { ImageID = 1, PostID = 1, ImagePath = @"\phongtro1.jpg"},
                new Image { ImageID = 2, PostID = 1, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 3, PostID = 1, ImagePath = @"\phongtro3.jpg"},

                new Image { ImageID = 4, PostID = 2, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 5, PostID = 2, ImagePath = @"\phongtro3.jpg"},
                new Image { ImageID = 6, PostID = 2, ImagePath = @"\phongtro1.jpg"},

                new Image { ImageID = 7, PostID = 3, ImagePath = @"\phongtro1.jpg"},
                new Image { ImageID = 8, PostID = 3, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 9, PostID = 3, ImagePath = @"\phongtro3.jpg"},

                new Image { ImageID = 10, PostID = 4, ImagePath = @"\phongtro1.jpg"},
                new Image { ImageID = 11, PostID = 4, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 12, PostID = 4, ImagePath = @"\phongtro3.jpg"},

                new Image { ImageID = 10, PostID = 5, ImagePath = @"\phongtro1.jpg"},
                new Image { ImageID = 11, PostID = 5, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 12, PostID = 5, ImagePath = @"\phongtro3.jpg"},

                new Image { ImageID = 10, PostID = 6, ImagePath = @"\phongtro1.jpg"},
                new Image { ImageID = 11, PostID = 6, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 12, PostID = 6, ImagePath = @"\phongtro3.jpg"},

                new Image { ImageID = 10, PostID = 7, ImagePath = @"\phongtro1.jpg"},
                new Image { ImageID = 11, PostID = 7, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 12, PostID = 7, ImagePath = @"\phongtro3.jpg"},

            });

            context.Comments.AddRange(new Comment[]
            {
                new Comment {CommentID = 1, PostID =1, UserID = 2, Content = "Haha", CreatedAt = DateTime.Now},
                new Comment {CommentID = 2, PostID =1, UserID = 2, Content = "Hihi", CreatedAt = DateTime.Now},
                new Comment {CommentID = 3, PostID =2, UserID = 3, Content = "Hehe", CreatedAt = DateTime.Now},
                new Comment {CommentID = 4, PostID =2, UserID = 3, Content = "Huhu", CreatedAt = DateTime.Now},
                new Comment {CommentID = 5, PostID =3, UserID = 1, Content = "Huhu", CreatedAt = DateTime.Now},
                new Comment {CommentID = 6, PostID =3, UserID = 3, Content = "HicHic", CreatedAt = DateTime.Now},

            });

            context.Ratings.AddRange(new Rating[]
            {
                new Rating {RatingID = 1, PostID = 1, UserID = 3, Star = 5, CreatedAt = DateTime.Now},
                new Rating {RatingID = 2, PostID = 1, UserID = 2, Star = 2, CreatedAt = DateTime.Now},
                new Rating {RatingID = 3, PostID = 2, UserID = 2, Star = 2, CreatedAt = DateTime.Now},
                new Rating {RatingID = 4, PostID = 2, UserID = 3, Star = 5, CreatedAt = DateTime.Now},
            });
        }
    }
}
