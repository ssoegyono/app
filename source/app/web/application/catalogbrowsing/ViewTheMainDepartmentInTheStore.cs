using app.web.core;

namespace app.web.application.catalogbrowsing
{
  public class ViewTheMainDepartmentInTheStore : IImplementAFeature
  {
      private readonly IFindDepartments findDepartments;


      public ViewTheMainDepartmentInTheStore(IFindDepartments findDepartments)
   {

       this.findDepartments = findDepartments;
   }

    public void process(IContainRequestInformation request)
    {
      
        findDepartments.get_the_main_departments();

    }
  }
}