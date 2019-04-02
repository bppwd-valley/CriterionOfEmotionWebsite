require 'test_helper'

class EnemiesControllerTest < ActionDispatch::IntegrationTest
  test "should get knife_skeleton" do
    get enemies_knife_skeleton_url
    assert_response :success
  end

end
