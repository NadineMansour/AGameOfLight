class ApplicationController < ActionController::Base
	before_action :configure_permitted_parameters, if: :devise_controller?

  protected

  def configure_permitted_parameters
devise_parameter_sanitizer.for(:sign_up) << [:school , :grade , :student_name , :student_class]
    devise_parameter_sanitizer.for(:sign_in) { |u| u.permit(:login, :email, :password, :remember_me) }
    devise_parameter_sanitizer.for(:account_update) { |u| u.permit(:email, :password, :password_confirmation, :current_password) }
  end



def authenticate_user
  if session[:user_id]
     # set current user object to @current_user object variable
    @current_user = Student.find session[:user_id] 
    return true	
  else
    redirect_to(:controller => 'sessions', :action => 'login')
    return false
  end
end



def save_login_state
  if session[:user_id]
    redirect_to(:controller => 'sessions', :action => 'home')
    return false
  else
    return true
  end



  # Virtual attribute for authenticating by either username or email
  # This is in addition to a real persisted field like 'username'
  attr_accessor :login
  # Prevent CSRF attacks by raising an exception.
  # For APIs, you may want to use :null_session instead.
  protect_from_forgery with: :exception
end
