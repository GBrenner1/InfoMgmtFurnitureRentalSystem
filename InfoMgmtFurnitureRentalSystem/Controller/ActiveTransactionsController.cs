﻿using InfoMgmtFurnitureRentalSystem.DAL;
using InfoMgmtFurnitureRentalSystem.Model;

namespace InfoMgmtFurnitureRentalSystem.Controller;

/// <summary>
///     Controller for the active transactions form
/// </summary>
public class ActiveTransactionsController
{
    #region Properties

    /// <summary>
    ///     The member who's current rentals will be shown
    /// </summary>
    public int CurMember { get; }

    /// <summary>
    ///     The employee looking at past customer transactions
    /// </summary>
    public int CurEmployee { get; }

    /// <summary>
    ///     all furniture that can be rented
    /// </summary>
    public IList<Furniture>? Furniture { get; set; }

    #endregion

    #region Constructors

    /// <summary>
    ///     creates a new active transactions controller
    /// </summary>
    /// <param name="memberId"></param>
    /// <param name="employeeId"></param>
    public ActiveTransactionsController(int memberId, int employeeId)
    {
        this.CurMember = memberId;
        this.CurEmployee = employeeId;
        this.Furniture = FurnitureDal.GetMembersCurrentRentedFurniture(memberId);
    }

    #endregion
}