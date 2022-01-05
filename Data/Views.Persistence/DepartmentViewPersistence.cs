﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.5.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Views.Persistence
{
	/// <summary>Static class for (extension) methods for fetching and projecting instances of Views.DtoClasses.DepartmentView from the entity model.</summary>
	public static partial class DepartmentViewPersistence
	{
		private static readonly System.Linq.Expressions.Expression<Func<EmployeeManagment.EntityClasses.DepartmentEntity, Views.DtoClasses.DepartmentView>> _projectorExpression = CreateProjectionFunc();
		private static readonly Func<EmployeeManagment.EntityClasses.DepartmentEntity, Views.DtoClasses.DepartmentView> _compiledProjector = CreateProjectionFunc().Compile();
	
		/// <summary>Empty static ctor for triggering initialization of static members in a thread-safe manner</summary>
		static DepartmentViewPersistence() { }
	
		/// <summary>Extension method which produces a projection to Views.DtoClasses.DepartmentView which instances are projected from the 
		/// results of the specified baseQuery, which returns EmployeeManagment.EntityClasses.DepartmentEntity instances, the root entity of the derived element returned by this query.</summary>
		/// <param name="baseQuery">The base query to project the derived element instances from.</param>
		/// <returns>IQueryable to retrieve Views.DtoClasses.DepartmentView instances</returns>
		public static IQueryable<Views.DtoClasses.DepartmentView> ProjectToDepartmentView(this IQueryable<EmployeeManagment.EntityClasses.DepartmentEntity> baseQuery)
		{
			return baseQuery.Select(_projectorExpression);
		}
		
		/// <summary>Extension method which produces a projection to Views.DtoClasses.DepartmentView which instances are projected from the
		/// EmployeeManagment.EntityClasses.DepartmentEntity entity instance specified, the root entity of the derived element returned by this method.</summary>
		/// <param name="entity">The entity to project from.</param>
		/// <returns>EmployeeManagment.EntityClasses.DepartmentEntity instance created from the specified entity instance</returns>
		public static Views.DtoClasses.DepartmentView ProjectToDepartmentView(this EmployeeManagment.EntityClasses.DepartmentEntity entity)
		{
			return _compiledProjector(entity);
		}
		
		private static System.Linq.Expressions.Expression<Func<EmployeeManagment.EntityClasses.DepartmentEntity, Views.DtoClasses.DepartmentView>> CreateProjectionFunc()
		{
			return p__0 => new Views.DtoClasses.DepartmentView()
			{
				Id = p__0.Id,
				IsActive = p__0.IsActive,
				NameEnglish = p__0.NameEnglish,
	// __LLBLGENPRO_USER_CODE_REGION_START ProjectionRegion_DepartmentView 
	// __LLBLGENPRO_USER_CODE_REGION_END 
			};
		}
	}
}

