// Namespace untuk aturan security di Application.
namespace KodaStore.Application.Security;

// Class static karena hanya menyimpan konstanta nama role.
public static class AppRoles
{
    // Role untuk pengguna biasa yang berbelanja.
    public const string Customer = "CUSTOMER";

    // Role untuk administrator yang mengelola katalog.
    public const string Admin = "ADMIN";
}