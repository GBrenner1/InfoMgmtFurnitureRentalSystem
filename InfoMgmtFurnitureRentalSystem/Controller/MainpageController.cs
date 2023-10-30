using InfoMgmtFurnitureRentalSystem.DAL;
using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.Controller;

/// <summary>
///     The controller for the main page
/// </summary>
public class MainpageController
{
    #region Properties

    /// <summary>
    ///     The currently logged in employee
    /// </summary>
    public Employee? CurrentEmployee { get; set; }

    /// <summary>
    ///     All members of the rental service
    /// </summary>
    public IList<Member> Members { get; set; }

    /// <summary>
    ///     all furniture that can be rented
    /// </summary>
    public IList<Furniture> Furnitures { get; set; }

    #endregion

    #region Constructors

    /// <summary>
    ///     the default controller for the mainpage controller
    /// </summary>
    public MainpageController()
    {
        this.Members = MemberDal.GetMembers();
        this.Furnitures = FurnitureDal.getFurniture();
    }

    #endregion

    #region Methods

    /// <summary>
    ///     searches members by name
    /// </summary>
    /// <param name="fname"></param>
    /// <param name="lname"></param>
    public void searchByName(string fname, string lname)
    {
        this.Members = MemberDal.searchByName(fname, lname);
    }

    /// <summary>
    ///     Searches members by ID
    /// </summary>
    /// <param name="id"></param>
    public void searchById(string id)
    {
        this.Members = MemberDal.searchById(id);
    }

    /// <summary>
    ///     searches members by phone number
    /// </summary>
    /// <param name="phone"></param>
    public void searchByPhone(string phone)
    {
        this.Members = MemberDal.searchByPhone(phone);
    }

    /// <summary>
    /// refreshes all members in list
    /// </summary>
    public void refreshMembers()
    {
        this.Members = MemberDal.GetMembers();
    }

    /// <summary>
    ///     Searches all furniture
    /// </summary>
    /// <param name="id"></param>
    /// <param name="category"></param>
    /// <param name="style"></param>
    public void searchFurniture(string id, string category, string style)
    {
        this.Furnitures = FurnitureDal.searchFurniture(id, category, style);
    }

    /// <summary>
    ///     gets all styles of furniture
    /// </summary>
    /// <returns></returns>
    public IList<string> getStyles()
    {
        return FurnitureDal.getStyles();
    }

    /// <summary>
    ///     gets all categories of furniture
    /// </summary>
    /// <returns></returns>
    public IList<string> getCategories()
    {
        return FurnitureDal.getCategories();
    }

    internal void refreshFurnitures()
    {
        throw new NotImplementedException();
    }

    #endregion
}