class StudentsController < ApplicationController
	def show
    @user = Student.find(params[:id])
  end



  def new
    @user = UStudent.new
  end



  def create
    @user = Student.new(user_params)
    if @user.save
      log_in @user
      flash[:success] = "Welcome!"
      redirect_to("gameview")
    else
      render 'new'
    end
  end



  private
    def user_params
      params.require(:student).permit(:email, :password,
                                   :password_confirmation)
    end
end
